using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace InternetCrawler
{
    public partial class MainForm : Form
    {
        List<List<String>> coll=new List<List<String>>();
        Thread workThread;
        ManualResetEvent mre = new ManualResetEvent(true);
        int portion = 1000;
        public MainForm()
        {
            InitializeComponent();
            progressBar1.Maximum = portion;       

        }
        //https://habrahabr.ru/post/139734/
        public void StartTest()
        {

            List<string> matches = new List<string> ();
            List<String> queue = new List<String>();
            queue.Add(coll[0][0]);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb web = new HtmlWeb();
            for (int i=0;i<coll.Count;i++)
            {
                
                Parallel.For(0, coll[i].Count, new ParallelOptions() { MaxDegreeOfParallelism = 10 }, (j,loopState) =>
                {
                    
                    try
                    {
                        document = web.Load(coll[i][j]);
                        
                        if (document.DocumentNode.SelectSingleNode("//body").InnerText.ToLower().Contains("программа"))
                        {
                            matches.Add(coll[i][j]);
                            textBox2.Invoke((MethodInvoker)delegate { textBox2.Text = matches.Count.ToString(); });
                            listView1.Invoke((MethodInvoker)delegate { listView1.Items.Add(coll[i][j]); });
                            //File.WriteAllText("test.txt", document.DocumentNode.SelectSingleNode("//body").InnerText);
                        }
                        List<String> tempColl = document.DocumentNode.Descendants("a")
                        .Where(a => a.Attributes["href"] != null && (a.Attributes["href"].Value.IndexOf("http://") == 0 || a.Attributes["href"].Value.IndexOf("https://") == 0) && !queue.Contains(a.Attributes["href"].Value))
                        .Select(a => a.Attributes["href"].Value)
                        .Distinct()
                        .Take(portion - queue.Count)
                        .ToList<String>();

                        if (tempColl.Count > 0)
                        {
                            queue.AddRange(tempColl);
                            textBox1.Invoke((MethodInvoker)delegate { textBox1.Text = queue.Count.ToString(); });
                            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value=queue.Count; });
                            if (queue.Count >= portion)
                            {
                                loopState.Stop();
                                return;
                            }
                            coll.Add(tempColl);
                        }
                        mre.WaitOne();

                    }
                    catch (Exception ex) { }
                });
                //for (int j=0;j<coll[i].Count;j++)
                //{
                //    try
                //    {
                //        document = web.Load(coll[i][j]);
                //        if(document.DocumentNode.SelectSingleNode("//body").InnerText.ToLower().Contains("программа"))
                //        {
                //            File.WriteAllText("test.txt", document.DocumentNode.SelectSingleNode("//body").InnerText);
                //        }
                //        List<String> tempColl = document.DocumentNode.Descendants("a")
                //        .Where(a => a.Attributes["href"] != null && (a.Attributes["href"].Value.IndexOf("http://") == 0 || a.Attributes["href"].Value.IndexOf("https://") == 0) && !queue.Contains(a.Attributes["href"].Value))
                //        .Select(a => a.Attributes["href"].Value)
                //        .Distinct()
                //        .Take(20000 - queue.Count)
                //        .ToList<String>();
                //        if (tempColl.Count > 0)
                //        {
                //            queue.AddRange(tempColl);
                //            textBox1.Invoke((MethodInvoker)delegate { textBox1.Text = queue.Count.ToString(); });
                //            if (queue.Count >= 20000)
                //                break;
                //            coll.Add(tempColl);
                //        }
                //    }
                //    catch (Exception ex) { }
                //}
                if (queue.Count >= portion)
                    break;
            }
            File.WriteAllLines("matches.txt",matches);

            //try
            //{
            //    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            //    HtmlWeb web = new HtmlWeb();

            //    document = web.Load(url.ToString());

            //    List<string> newColl = document.DocumentNode.Descendants("a")
            //        .Where(a => a.Attributes["href"] != null && (a.Attributes["href"].Value.IndexOf("http://")==0 || a.Attributes["href"].Value.IndexOf("https://")==0) && !coll.Contains(a.Attributes["href"].Value))
            //        .Select(a => a.Attributes["href"].Value)
            //        .Distinct()
            //        .ToList<String>();
            //    coll.AddRange(newColl);
            //    textBox1.Invoke((MethodInvoker)delegate { textBox1.Text = coll.Count.ToString(); });

            //    newColl.ForEach(c =>
            //    {
            //        StartTest(c);
            //    });
            //}
            //catch (Exception ex) { }
            ////for (int i = 0; i < newColl.Count; i++)
            //{
            //    try
            //    {
            //        document = web.Load(coll[i]);
            //        List<String> tempColl = document.DocumentNode.Descendants("a")
            //        .Where(a => a.Attributes["href"] != null && (a.Attributes["href"].Value.Contains("http://") || a.Attributes["href"].Value.Contains("https://")))
            //        .Select(a => a.Attributes["href"].Value)
            //        .Distinct()
            //        .ToList<String>();
            //        if (tempColl.Count > 0)
            //        {
            //            newColl.AddRange(tempColl.Except(newColl).Except(coll));
            //            textBox1.Invoke((MethodInvoker)delegate { textBox1.Text = newColl.Count.ToString(); });
            //        }
            //    }
            //    catch (Exception ex) { }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (workThread == null)
            {
                //https://msdn.microsoft.com/ru-ru/library/system.windows.forms.listview.columns(v=vs.110).aspx
                //coll.Add(new List<string>() { "https://msdn.microsoft.com/ru-ru/library/system.windows.forms.listview.columns(v=vs.110).aspx" });
                coll.Add(new List<string>() { "https://habrahabr.ru/post/139734/" });
                //mre.Set();
                workThread = new Thread(StartTest);
                workThread.Start();
                
            }
            else if (workThread.ThreadState == ThreadState.Running)
                mre.Reset();
            else if (workThread.ThreadState == ThreadState.WaitSleepJoin)
                mre.Set();
        }
    }
}
