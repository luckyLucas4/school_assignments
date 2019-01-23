using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaregistret
{
    class Movie : Media
    {
        string director;
        int length;

        public Movie(string title, string director, int length) : base(title)
        {
            this.director = director;
            this.length = length;
        }

        public override string ToString()
        {
            if (length == 1)
            {
                return string.Format("{0} ({1}, {2} minut)", title, director, length);
            }
            else
            {
                return string.Format("{0} ({1}, {2} minuter)", title, director, length);
            }
        }
    }
}
