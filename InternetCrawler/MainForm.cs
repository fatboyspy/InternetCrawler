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

namespace InternetCrawler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb web = new HtmlWeb();

            document = web.Load("https://habrahabr.ru/post/139734/");

            List<String> coll= document.DocumentNode.Descendants("a")
                .Where(a=>a.Attributes["href"]!=null&& (a.Attributes["href"].Value.Contains("http://")||a.Attributes["href"].Value.Contains("https://")))
                .Select(a => a.Attributes["href"].Value)
                .Distinct()
                .ToList<String>();

            File.WriteAllText("test.html", document.DocumentNode.InnerHtml);
            File.WriteAllText("test.txt", document.DocumentNode.SelectSingleNode("//body").InnerText.Replace("\r\n\r\n","\r\n").Replace("  "," "));

        }
    }
}
