using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaregistret
{
    class Media
    {
        protected string title;

        public Media (string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return string.Format("Titel: {0}", title);
        }
    }
}
