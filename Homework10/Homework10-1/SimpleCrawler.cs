using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

namespace Homework10_1
{
    class SimpleCrawler
    {
        public event Action UpdateUI;
        public ConcurrentDictionary<string, bool> urls { get; set; } = new ConcurrentDictionary<string, bool>();
        private int count = 0;
        public ConcurrentQueue<WebPage> WebPages { set; get; } = new ConcurrentQueue<WebPage>();
        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; } = 10;

        public void Crawl()
        {
            count = 0;
            WebPage wp = new WebPage();
            while (this.WebPages.TryDequeue(out wp))
            {
                wp = null;
            }
            //开始爬行了
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count >= MaxPage) break;
                //Console.WriteLine("爬行" + current + "页面!");
                string html = null;
                WebPage webPage = new WebPage();
                webPage.URL = current;
                try
                {
                    html = DownLoad(current); // 下载
                    urls[current] = true;
                    webPage.IsCrawled = true;

                    
                    Parse(html, current);//解析,并加入新的链接
                    
                }
                catch(Exception ex)
                {
                    webPage.ErrorMsg = ex.Message;
                    webPage.IsCrawled = false;
                }

                this.WebPages.Enqueue(webPage);
                UpdateUI();
                count++;               
                //爬行结束
            }
        }
        public string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }
        private void Parse(string html, string current)
        {
            MatchCollection matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, current);//转绝对路径
                                                   //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.ContainsKey(linkUrl))
                {
                    urls.TryAdd(linkUrl, false);
                }
            }
        }
        private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
