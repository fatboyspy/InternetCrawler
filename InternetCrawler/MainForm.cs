using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading;
using System.Text.RegularExpressions;

namespace InternetCrawler
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция для хранения отобраных URL адресов
        /// </summary>
        List<List<String>> coll = new List<List<String>>();
        /// <summary>
        /// Главный рабочий поток
        /// </summary>
        Thread workThread;
        /// <summary>
        /// Для управления потоками, приостановка/продолжение
        /// </summary>
        ManualResetEvent mre = new ManualResetEvent(true);
        /// <summary>
        /// Порция адресов для обработки
        /// </summary>
        int portion;
        /// <summary>
        /// Количество потоков для обработки
        /// </summary>
        int threads;
        /// <summary>
        /// Переменная для блокировки важных секций в потоке
        /// </summary>
        object lockerVariable;
        /// <summary>
        /// Паттерн для текстового поиска
        /// </summary>
        String textPattern;
        /// <summary>
        /// Главная форма
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            lockerVariable = new object();
            portion = (int)numUDURLs.Value;
            pbScanProgress.Maximum = portion;
            threads = (int)numUDThreads.Value;           
            //это для примера
            tbURL.Text = "https://habrahabr.ru/post/139734/";            
            tbText.Text = "async await ";
        }
        public void StartScanning()
        {
            //Создаем заглушку для хранения списка-очереди
            //в нем будем хранить элементы адресов для избегания повторов и контроля за количеством адресов
            List<String> queue = new List<String>();
            //добавляем в очередь элемент из коллекции
            queue.Add(coll[0][0]);
            //Заглушка для ХТМЛ документа
            HtmlAgilityPack.HtmlDocument document=null;
            //для получения документа по адресу
            HtmlWeb web = new HtmlWeb();
            for (int i = 0; i < coll.Count; i++)
            {
                //запускаем вложенный цикл с паралельной многопоточной обработкой
                Parallel.For(0, coll[i].Count, new ParallelOptions() { MaxDegreeOfParallelism = threads }, (j, loopState) =>
                {
                    //приостанавливаем работу потоков, если несигнальное состояние
                    mre.WaitOne();
                    try
                    {
                        //создаем заглушку для добавления элемента в список
                        ListViewItem lvItem = new ListViewItem(new string[] { coll[i][j], "LOADING", "" });
                        //добавляем в список сканируемых
                        lvScanning.Invoke((MethodInvoker)delegate { lvScanning.Items.Add(lvItem); });

                        try
                        {
                            //загружаем документ
                            document = web.Load(coll[i][j]);
                            //если удалось загрузить
                            if (document != null)
                            {
                                //помечаем элемент как "сканируемый"
                                lvScanning.Invoke((MethodInvoker)delegate{
                                    if (lvScanning.Items.Contains(lvItem))
                                        {
                                        int indexItem = lvScanning.Items.IndexOf(lvItem);
                                        lvScanning.Items[indexItem].SubItems[1].Text = "SCANNING";
                                    }});
                                //если поиск по паттерну вернул хоть что-то
                                if (!String.IsNullOrEmpty( Regex.Match( document.DocumentNode.SelectSingleNode("//body").InnerText,textPattern,RegexOptions.IgnoreCase).Value))
                                {
                                    //помечаем элемент как "найдено"
                                    //и перекрашиваем в зеленый цвет
                                    lvScanning.Invoke((MethodInvoker)delegate
                                        {
                                            if (lvScanning.Items.Contains(lvItem))
                                            {
                                                int indexItem = lvScanning.Items.IndexOf(lvItem);
                                                lvScanning.Items[indexItem].BackColor = Color.LightGreen;
                                                lvScanning.Items[indexItem].SubItems[1].Text = "FOUND";
                                            }
                                        });
                                }
                                //если не вернул
                                else
                                {
                                    //помечаем как "не найдено"
                                    lvScanning.Invoke((MethodInvoker)delegate
                                    {
                                        if (lvScanning.Items.Contains(lvItem))
                                        {
                                            int indexItem = lvScanning.Items.IndexOf(lvItem);
                                            lvScanning.Items[indexItem].SubItems[1].Text = "NOT FOUND";
                                        }
                                    });
                                }
                            }
                        }
                        //если во время загрузки документа возникло исключение
                        catch (Exception ex)
                        {
                            //помечаем элемент статусом "ошибка"
                            //и добавляем сообщение об ошибке
                            //а также перекрашиваем в красный цвет
                            lvScanning.Invoke((MethodInvoker)delegate{
                            if (lvScanning.Items.Contains(lvItem))
                            {
                                int indexItem = lvScanning.Items.IndexOf(lvItem);
                                lvScanning.Items[indexItem].BackColor = Color.Red;
                                lvScanning.Items[indexItem].SubItems[1].Text = "ERROR";
                                lvScanning.Items[indexItem].SubItems[2].Text = ex.Message;
                            }});
                        }
                        //блокируем секцию, так как возможны варианты
                        lock (lockerVariable)
                        {
                            //убираем элемент из списка сканируемых
                            lvScanning.Invoke((MethodInvoker)delegate { lvScanning.Items.Remove(lvItem); });
                            //помещаем его в список отсканированных
                            lvScanned.Invoke((MethodInvoker)delegate
                            {
                                ListViewItem lvItemScanned = new ListViewItem(new string[] { (lvScanned.Items.Count + 1).ToString(), lvItem.SubItems[0].Text, lvItem.SubItems[1].Text, lvItem.SubItems[2].Text });
                                lvItemScanned.BackColor = lvItem.BackColor;
                                lvScanned.Items.Add(lvItemScanned);
                            });
                            //меняем значение прогрессбара
                            pbScanProgress.Invoke((MethodInvoker)delegate { pbScanProgress.Value = lvScanned.Items.Count; });
                            //есди текущий размер очереди меньше желаемого
                            if (queue.Count < portion)
                            {
                                //формируем временный список ссылок из текущего документа
                                List<String> tempColl = document.DocumentNode.Descendants("a")
                                //берем ссылку если она еще не присутствует в очереди
                                .Where(a => a.Attributes["href"] != null && (a.Attributes["href"].Value.IndexOf("http://") == 0 || a.Attributes["href"].Value.IndexOf("https://") == 0) && !queue.Contains(a.Attributes["href"].Value))
                                //берем только значение URL
                                .Select(a => a.Attributes["href"].Value)
                                //убираем дубликаты
                                .Distinct()
                                //если вернулось больше чем надо, то немножко уменьшаем порцию
                                .Take(portion - queue.Count)
                                .ToList<String>();
                                //если вернулась непустая коллекция
                                if (tempColl.Count > 0)
                                {
                                    //добавляем в очередь
                                    queue.AddRange(tempColl);
                                    //добавляем в коллекцию для дальнейшего обхода
                                    coll.Add(tempColl);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                });
            }
        }
        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (workThread != null)
                    workThread.Abort();
            }
            else
                e.Cancel = true;
        }
        /// <summary>
        /// Обработчик запуска процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //паттерн для поиска URL в строке
            string urlPattern = @"((http|https)+\:\/\/)[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)]";
            //преобразовываем в нормальный вид
            tbURL.Text = Regex.Match(tbURL.Text, urlPattern, RegexOptions.IgnoreCase).Value;
            //тоже самое и с текстом
            textPattern = tbText.Text.Trim().Replace("  ", " ").Replace(" ", ".{1,10}");
            //если поток еще не создан или сброшен или на паузе
            if (workThread == null || workThread.ThreadState == ThreadState.Aborted || workThread.ThreadState == ThreadState.WaitSleepJoin)
            {   
                //ставим в сигнальное состояние
                mre.Set();
                //если поток не создан                
                if (workThread == null)
                {
                    //задаем размер порции для выборки
                    portion = (int)numUDURLs.Value;
                    //определяем максимум для прогрессбара
                    pbScanProgress.Maximum = portion;
                    //и текущее значение
                    pbScanProgress.Value = 0;
                    //задаем количество потоков
                    threads = (int)numUDThreads.Value;
                    //добавляем значение адреса для поиска
                    coll.Add(new List<string>() { tbURL.Text });
                    //очищаем списки
                    lvScanning.Items.Clear();
                    lvScanned.Items.Clear();
                    //формируем поток
                    workThread = new Thread(StartScanning);
                    //запускаем
                    workThread.Start();
                }
            }
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            numUDThreads.Enabled = false;
            numUDURLs.Enabled = false;

            tbURL.Enabled = false;
            tbText.Enabled = false;
        }
        /// <summary>
        /// Обработчик нажатия на кнопку паузы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            //ставим в сигнальное состояние для приостановки потоков
            mre.Reset();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
        }
        /// <summary>
        /// Обработчик нажатия на кнопку стоп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            workThread.Abort();
            workThread = null;

            coll = new List<List<String>>();
            lvScanning.Items.Clear();

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            numUDThreads.Enabled = true;
            numUDURLs.Enabled = true;

            tbURL.Enabled = true;
            tbText.Enabled = true;
        }

        private void lvScanned_DoubleClick(object sender, EventArgs e)
        {
            if (lvScanned.SelectedItems.Count > 0)
            {
                URLForm urlForm = new URLForm(lvScanned.SelectedItems[0].SubItems[1].Text, lvScanned.SelectedItems[0].SubItems[2].Text, lvScanned.SelectedItems[0].SubItems[3].Text);
                urlForm.ShowDialog();
            }
        }
    }
}
