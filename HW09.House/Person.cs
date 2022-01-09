using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.House
{
    class Person
    {
        private string _name;
        private House _house;

        public Person()
        {
            _name = "Tom";
            _house = new House(150);
        }
        public Person(string name, House house)
        {
            this._name = name;
            this._house = house;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public House House
        {
            get { return _house; }
            set { _house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"My name is {_name}.");
            _house.ShowData();
            _house.Door.ShowData();
        }
    }
}