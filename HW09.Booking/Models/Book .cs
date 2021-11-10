using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Models
{
    class Book : Search
    {
        private string _hotel;
        private List<string> _hotelEgypt = new List<string>() { "Sunny Days", "Moon Hotel", "Panarama Resort" };
        private List<string> _hotelGreece = new List<string>() { "Old Town", "Hellenic House", "Komissa Beach" };
        private List<string> _hotelFrance = new List<string>() { "Temple Apartments", "Guest House", "La Rappe" };
        private List<string> _hotelEngland = new List<string>() { "Americana Hotel", "Paskins House", "Woodthorpe" };
        private List<string> _hotelTurkey = new List<string>() { "Nova Plaza", "Magnova Studios", "Hich Konya" };

        public Book()
        {

        }

        public Book(string hotel, List<string> hotelEgypt, List<string> hotelGreece, List<string> hotelFrance, List<string> hotelEngland, List<string> hotelTurkey)
        {
            this._hotel = hotel;
            this._hotelEgypt = hotelEgypt;
            this._hotelGreece = hotelGreece;
            this._hotelFrance = hotelFrance;
            this._hotelEngland = hotelEngland;
            this._hotelTurkey = hotelTurkey;
        }

        public string Hotel
        {
            get { return _hotel; }
            set { _hotel = value; }
        }

        public List<string> HotelEgypt
        {
            get { return _hotelEgypt; }
            set { _hotelEgypt = value; }
        }

        public List<string> HotelGreece
        {
            get { return _hotelGreece; }
            set { _hotelGreece = value; }
        }

        public List<string> HotelFrance
        {
            get { return _hotelFrance; }
            set { _hotelFrance = value; }
        }

        public List<string> HotelEngland
        {
            get { return _hotelEngland; }
            set { _hotelEngland = value; }
        }

        public List<string> HotelTurkey
        {
            get { return _hotelTurkey; }
            set { _hotelTurkey = value; }
        }
    }
}