using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.CatalogUnity
{
    class Item
    {
        private string _name;
        private string _code;
        private string _category;
        private string _size;

        public Item()
        {
        }

        public Item(string name, string code, string category, string size)
        {
            this._name = name;
            this._code = code;
            this._category = category;
            this._size = size;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}