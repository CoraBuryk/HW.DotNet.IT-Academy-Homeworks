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

        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Experience { get; set; }

        public string Responsibilities { get; set; }

        public string Technologies { get; set; }

        public string GitHub { get; set; }

        public int Salary { get; set; }

        public Characters()
        {

        }

        public Characters(Guid id, string firstName, string lastName, int experience,
            string responsibilities, string technologies, string gitHub, int salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            Responsibilities = responsibilities;
            Technologies = technologies;
            GitHub = gitHub;
            Salary = salary;
        }
    }
}