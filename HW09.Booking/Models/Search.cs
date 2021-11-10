using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Models
{
    class Search
    {
        private string _destination;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private int _numberOfPerson;
        private List<string> _country = new List<string>() { "Egypt", "Greece", "France", "England", "Turkey" };

        public Search()
        { 
        }

        public Search(string destination, DateTime checkIn, DateTime checkOut, int numberOfPerson)
        {
            this._destination = destination;
            this._checkIn = checkIn;
            this._checkOut = checkOut;
            this._numberOfPerson = numberOfPerson;
        }

        public string Destination
        {
            get { return _destination; }
            set {  _destination = value; }
        }

        public List<string> Country
        {
            get { return _country; }
            set {  _country = value; }
        }

        public DateTime CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        public int NumberOfPerson
        {
            get { return _numberOfPerson; }
            set { _numberOfPerson = value; }
        }
    }
}