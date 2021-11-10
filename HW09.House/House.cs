using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.House
{
    class House
    {
        private int _area;
        private Door _door;

        public House(int area)
        {
            this._area = area;
            _door = new Door();

        }
        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public Door Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {_area} m2");
        }
    }

    class Door
    {
        private string _color;

        public Door()
        {
            _color = "brown";
        }
        public Door(string color)
        {
            this._color = color;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {_color}");
        }

    }
}