using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Salary
{
    class Developers : Characters
    {
        private string _juniorDeveloper = "Junior Developer";
        private string _middleDeveloper = "Middle Developer";
        private string _seniorDeveloper = "Senior Developer";
        private string _teamLeader = "Team Leader";
        private string _architect = "Architect";

        public Developers()
        {

        }

        public Developers(string juniorDeveloper, string middleDeveloper, string seniorDeveloper,
            string teamLeader, string architect)
        {
            this._juniorDeveloper = juniorDeveloper;
            this._middleDeveloper = middleDeveloper;
            this._seniorDeveloper = seniorDeveloper;
            this._teamLeader = teamLeader;
            this._architect = architect;
        }

        public string JuniorDeveloper
        {
            get { return _juniorDeveloper; }
            set { _juniorDeveloper = value; }
        }
        public string MiddleDeveloper
        {
            get { return _middleDeveloper; }
            set { _middleDeveloper = value; }
        }
        public string SeniorDeveloper
        {
            get { return _seniorDeveloper; }
            set { _seniorDeveloper = value; }
        }
        public string TeamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        }
        public string Architect
        {
            get { return _architect; }
            set { _architect = value; }
        }
    }
}