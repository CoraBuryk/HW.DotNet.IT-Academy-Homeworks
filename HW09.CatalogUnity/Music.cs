using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.CatalogUnity
{
    class Music
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
        
        public void Play() => Console.WriteLine(new Film().ToString());
        // Cannot use ovverride with method Play() cause it give us an exeption "no suitable method found to override" 

        //public override string ToString() => base.ToString();
    }
}