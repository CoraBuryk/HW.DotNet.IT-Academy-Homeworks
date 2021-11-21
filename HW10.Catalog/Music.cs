using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Catalog
{
    class Music : Item
    {
        private string _singer;
        private string _lenght;

        public Music()
        {
        }

        public Music(string singer, string lenght)
        {
            this._singer = singer;
            this._lenght = lenght;
        }

        public string Singer
        {
            get { return _singer; }
            set { _singer = value; }
        }

        public string Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }

        public void Play()
        {
            Console.WriteLine(new Music().ToString());
        }
    }
}
