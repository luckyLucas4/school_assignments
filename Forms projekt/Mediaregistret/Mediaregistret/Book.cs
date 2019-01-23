using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaregistret
{
    class Book : Media
    {
        string author;
        int pages;

        public Book(string title, string author, int pages) : base(title)
        {
            this.author = author;
            this.pages = pages;
        }

        public override string ToString()
        {
            if(pages == 1)
            {
                return string.Format("{0} ({1}, {2} sida)", title, author, pages);
            }
            else
            {
                return string.Format("{0} ({1}, {2} sidor)", title, author, pages);
            }
        }
    }
}
