using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Salary
{
    class Salary : Developers
    {
        protected const int _base = 500;
        private int _juniorSalary = _base;
        private int _middleSalary = _base * 3;
        private int _seniorSalary = _base * 5 + 300;
        private int _leaderSalary = _base * 8 + 500;
        private int _architectSalary = _base * 12 + 1200;

        public Salary()
        {

        }
        public Salary(int juniorSalary, int middleSalary, int seniorSalary, int leaderSalary, int architectSalary)
        {
            this._juniorSalary = juniorSalary;
            this._middleSalary = middleSalary;
            this._seniorSalary = seniorSalary;
            this._leaderSalary = leaderSalary; ;
            this._architectSalary = architectSalary;
        }
 
        public int JuniorSalary
        {
            get { return _juniorSalary; }
            set { _juniorSalary = value; }
        }
        public int MiddleSalary
        {
            get { return _middleSalary; }
            set { _middleSalary = value; }
        }
        public int SeniorSalary
        {
            get { return _seniorSalary; }
            set { _seniorSalary = value; }
        }
        public int LeaderSalary
        {
            get { return _leaderSalary; }
            set { _leaderSalary = value; }
        }
        public int ArchitectSalary
        {
            get { return _architectSalary; }
            set { _architectSalary = value; }
        }
    }
}