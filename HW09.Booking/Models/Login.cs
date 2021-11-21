using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Models
{
    class Login
    {
        private string _name;
        private string _email;
        private Guid _ID = new Guid();
        private string _password;

        public Login()
        {

        }

        public Login(string name, string email,string password) 
        {
            this._name = name;
            this._email = email;
            this._password = password;
        }

        public string Name
        {
            get { return _name; }
            set {  _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Guid ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }
}