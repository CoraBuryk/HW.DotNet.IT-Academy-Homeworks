using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Salary
{
    class Characters
    {
        protected const string _companyName = "Keighley's Inc";
        public string CompanyName { get { return _companyName; } }

        private Guid _id;
        private string _firstName;
        private string _lastName;
        private int _experience;
        private string _responsibilities;
        private string _technologies;
        private string _gitHub;
        private int _salary;

        public Characters()
        {

        }

        public Characters(Guid id, string firstName, string lastName, int experience,
            string responsibilities, string technologies, string gitHub, int salary)
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._experience = experience;
            this._responsibilities = responsibilities;
            this._technologies = technologies;
            this._gitHub = gitHub;
            this._salary = salary;
        }

        public Guid ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public string Responsibilities
        {
            get { return _responsibilities; }
            set { _responsibilities = value; }
        }
        public string Technologies
        {
            get { return _technologies; }
            set { _technologies = value; }
        }

        public string GitHub
        {
            get { return _gitHub; }
            set { _gitHub = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}