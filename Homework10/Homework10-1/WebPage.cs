using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_1
{
    class WebPage
    {
        public String URL { set; get; }
        public bool IsCrawled { set; get; }
        public String ErrorMsg { set; get; }
        public WebPage(String url, bool isCrawled)
        {
            this.URL = url;
            this.IsCrawled = isCrawled;
        }
        public WebPage() { }
    }
}
