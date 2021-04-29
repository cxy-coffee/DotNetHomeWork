using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework09_1
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

            webPageBindingSource.DataSource = simpleCrawler.WebPages;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            String startURL = comboBoxFirstURL.Text;
            simpleCrawler.urls.Clear();
            simpleCrawler.urls.Add(startURL, false);
            simpleCrawler.WebPages.Clear();
            simpleCrawler.Crawl();
            webPageBindingSource.ResetBindings(false);
        }
    }
}
