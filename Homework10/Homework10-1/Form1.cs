using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework10_1
{
    public partial class Form1 : Form
    {
        private SimpleCrawler simpleCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();

            List<WebPage> firstWebPages = new List<WebPage>();
            WebPage webPage1 = new WebPage(@"http://www.cnblogs.com/dstang2000/", false);
            firstWebPages.Add(webPage1);
            WebPage webPage2 = new WebPage(@"http://www.baidu.com", false);
            firstWebPages.Add(webPage2);
            comboBoxFirstURL.DataSource = firstWebPages;
            comboBoxFirstURL.DisplayMember = "URL";

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            String startURL = comboBoxFirstURL.Text;

            Match match = Regex.Match(startURL, SimpleCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            simpleCrawler.HostFilter = "^" + host + "$";
            simpleCrawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";

            simpleCrawler.urls.Clear();
            simpleCrawler.urls.TryAdd(startURL, false);

            simpleCrawler.UpdateUI += () =>
            {
                webPageBindingSource.DataSource = simpleCrawler.WebPages.ToArray();
                webPageBindingSource.ResetBindings(false);
            };

            Thread thread = new Thread(simpleCrawler.Crawl);
            thread.Start();
        }
    }
}
