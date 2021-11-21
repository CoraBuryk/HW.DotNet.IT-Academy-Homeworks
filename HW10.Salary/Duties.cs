using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Salary
{
    class Duties : Developers
    {
        List<string> junior;
        List<string> middle;
        List<string> senior;
        List<string> teamLeader;
        List<string> architect;
        public Duties()
        {
        }

        public virtual string DutiesForJunior(List<string> junior)
        {
            junior = new List<string>();
            junior.Add("Make programming documentation and refresh existing documentation.");
            junior.Add("Configure, create and execute basic applications using the C# language.");
            junior.Add("Help and support other colleagues on different undertakings.");
            junior.Add("Drive colleagues to stay aware of activities’ due dates and inside the customers' financial plans.");
            junior.Add("Actualize best practices, models and techniques including quality and conveyance philosophies.");
            return junior.ToString();
        }

        public  virtual string DutiesForMiddle(List<string> middle)
        {
            middle.Add("Tasked with designing a piece of the application to be prepared for the further transition to a senior developer.");
            middle.Add("Turning tickets into solutions.");
            middle.Add("Providing estimates on tasks.");
            middle.Add("Assisting in decomposing larger sections of work.");
            middle.Add("Design normalized DB schemas while taking into account the queries that will be issued.");
            return middle.ToString();
        }
        
        public virtual string DutiesForSenior(List<string> senior)
        {
            senior.Add("Brainstorm the right technological solutions to complex problems.");
            senior.Add("They take charge of the team, coordinating its workflow.");
            senior.Add("Have professional experience with more than 6 platforms.");
            senior.Add("Have enough knowledge to build their own custom framework.");
            senior.Add("Seniors are the source advice on platform internals.");
            return senior.ToString();
        }

        public virtual string DutiesForTeamLeader(List<string> teamLeader)
        {
            teamLeader.Add("Lead a team to reach the targets someone with good ideas.");
            teamLeader.Add("Dealing with contracts, bookkeeping and other paperwork.");
            teamLeader.Add("Have to hire people and select specialists.");
            teamLeader.Add("Build the development process and establish relationships with the team.");
            teamLeader.Add("Providing support for the desk with application and infrastructure questions or issues.");
            return teamLeader.ToString();
        }

        public virtual string DutiesForArchitect(List<string> architect)
        {
            architect.Add("Analyzing the technology environment.");
            architect.Add("Analyzing enterprise specifics.");
            architect.Add("Analyzing and documenting requirements.");
            architect.Add("Setting the collaboration framework.");
            architect.Add("Creating a solution prototype.");
            return architect.ToString();
        }

        public virtual string Duty()
        {
            string responsibilities = Responsibilities;
            
            if (Experience < 2)
            {
                responsibilities = DutiesForJunior(junior);
            }
            else
            {
                if (Experience > 0 && Experience < 3)
                {
                    responsibilities = DutiesForMiddle(middle);
                }
                else
                {
                    if (Experience > 3 && Experience < 5)
                    {
                        responsibilities = DutiesForSenior(senior);
                    }
                    else
                    {
                        if (Experience > 5 && Experience < 8)
                        {
                            responsibilities = DutiesForTeamLeader(teamLeader);
                        }
                        else responsibilities = DutiesForArchitect(architect);

                    }
                }
            }
            return responsibilities;
        }
    }
}