using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace InternetCrawler
{
    class Page
    {
        String URL { get; set; }
        HtmlDocument HTMLDocument { get; set; }
        Page ParentPage { get; set; }
        PageState State { get; set; }


        public override bool Equals(Object page)
        {
            return this.URL.Equals(((Page)page).URL);
        }
        public override int GetHashCode()
        {
            return this.URL.GetHashCode();
        }
    }

    enum PageState
    {
        Pending,
        Loading,
        Found,
        NotFound,
        Error
    }
}
