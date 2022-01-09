using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Catalog
{
    class Film : Item
    {
        private string _director;
        private string _mainActor;
        private string _mainActress;

        public Film()
        {
        }

        public Film(string director, string mainActor, string mainActress)
        {
            this._director = director;
            this._mainActor = mainActor;
            this._mainActress = mainActress;
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string MainActor
        {
            get { return _mainActor; }
            set { _mainActor = value; }
        }

        public string MainActress
        {
            get { return _mainActress; }
            set { _mainActress = value; }
        }

        public void Play()
        {
            Console.WriteLine(new Film().ToString());
            Console.WriteLine(string.Join(",", new Film()));
        }
    }
}
