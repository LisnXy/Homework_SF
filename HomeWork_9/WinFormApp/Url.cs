using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    class Url
    {
        public string url { get; set; }
        public int index = 0;

        public Url(string url)
        {
            this.url = url;
        }
    }
}
