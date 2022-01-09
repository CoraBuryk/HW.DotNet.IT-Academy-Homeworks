using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.Booking.Models
{
    class Purchase : Book
    {
        private int _costSunnyDay = 23;
        private int _costMoonHotel = 55;
        private int _costPanaramaResort = 78;
        private int _costOldTown = 17;
        private int _costHellenicHouse = 45;
        private int _costKomissaBeach = 98;
        private int _costTempleApartments = 47;
        private int _costGuestHouse = 92;
        private int _costLaRappe = 88;
        private int _costAmericanaHotel = 102;
        private int _costPaskinsHouse = 65;
        private int _costWoodthorpe = 74;
        private int _costNovaPlaza = 15;
        private int _costMagnovaStudios = 69;
        private int _costHichKonya = 41;

        public Purchase()
        {
        }
        public Purchase(int costSunnyDay, int costMoonHotel, int costPanaramaResort, 
            int costOldTown, int costHellenicHouse,int costKomissaBeach, int costTempleApartments,
            int costGuestHouse, int costLaRappe, int costAmericanaHotel, int costPaskinsHouse,
            int costWoodthorpe, int costNovaPlaza, int costMagnovaStudios, int costHichKonya)
        {
            this._costSunnyDay = costSunnyDay;
            this._costMoonHotel = costMoonHotel;
            this._costPanaramaResort = costPanaramaResort;
            this._costOldTown = costOldTown;
            this._costHellenicHouse = costHellenicHouse;
            this._costKomissaBeach = costKomissaBeach;
            this._costTempleApartments = costTempleApartments;
            this._costGuestHouse = costGuestHouse;
            this._costLaRappe = costLaRappe;
            this._costAmericanaHotel = costAmericanaHotel;
            this._costPaskinsHouse = costPaskinsHouse;
            this._costWoodthorpe = costWoodthorpe;
            this._costNovaPlaza = costNovaPlaza;
            this._costMagnovaStudios = costMagnovaStudios;
            this._costHichKonya = costHichKonya;
        }

        public int CostSunnyDay
        {
            get { return _costSunnyDay; }
            set { _costSunnyDay = value; }
        }

        public int CostMoonHotel
        {
            get { return _costMoonHotel; }
            set { _costMoonHotel = value; }
        }

        public int CostPanaramaResort
        {
            get { return _costPanaramaResort; }
            set { _costPanaramaResort = value; }
        }

        public int CostOldTown
        {
            get { return _costOldTown; }
            set { _costOldTown = value; }
        }

        public int CostHellenicHouse
        {
            get { return _costHellenicHouse; }
            set { _costHellenicHouse = value; }
        }

        public int CostKomissaBeach
        {
            get { return _costKomissaBeach; }
            set { _costKomissaBeach = value; }
        }

        public int CostTempleApartments
        {
            get { return _costTempleApartments; }
            set { _costTempleApartments = value; }
        }

        public int CostGuestHouse
        {
            get { return _costGuestHouse; }
            set { _costGuestHouse = value; }
        }

        public int CostLaRappe
        {
            get { return _costLaRappe; }
            set { _costLaRappe = value; }
        }

        public int CostAmericanaHotel
        {
            get { return _costAmericanaHotel; }
            set { _costAmericanaHotel = value; }
        }

        public int CostPaskinsHouse
        {
            get { return _costPaskinsHouse; }
            set { _costPaskinsHouse = value; }
        }

        public int CostWoodthorpe
        {
            get { return _costWoodthorpe; }
            set { _costWoodthorpe = value; }
        }

        public int CostNovaPlaza
        {
            get { return _costNovaPlaza; }
            set { _costNovaPlaza = value; }
        }

        public int CostMagnovaStudios
        {
            get { return _costMagnovaStudios; }
            set { _costMagnovaStudios = value; }
        }

        public int CostHichKonya
        {
            get { return _costHichKonya; }
            set { _costHichKonya = value; }
        }
    }
}