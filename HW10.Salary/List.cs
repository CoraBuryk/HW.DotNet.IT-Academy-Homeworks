using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Salary
{
    internal class List : Developers
    {
        Duties duties = new Duties();
        Salary salary = new Salary();

        public void Employee1()
        {
            FirstName = "Jenn";
            LastName = "Bennett";
            ID = Guid.NewGuid();
            Experience = 2;
            Responsibilities = duties.Duty(); //System.Collections.Generic.List`1[System.String] on console
            GitHub = "https://github.com/JennBenett";

            Console.WriteLine($"Full name: {FirstName} {LastName}, Experience: {Experience}, Title: " +
                $"{MiddleDeveloper}, Salary: {salary.MiddleSalary}, GitHub: {GitHub}");
        }
        public void Employee2()
        {
            FirstName = "Steven";
            LastName = "Christianson";
            ID = Guid.NewGuid();
            Experience = 0;
            Responsibilities = duties.Duty();
            GitHub = "https://github.com/StevenChristianson";

            Console.WriteLine($"Full name: {FirstName} {LastName}, Experience: {Experience}, Title: " +
                $"{JuniorDeveloper}, Salary: {salary.JuniorSalary}, GitHub: {GitHub}");
        }
        public void Employee3()
        {
            FirstName = "Roman";
            LastName = "Garbutt";
            ID = Guid.NewGuid();
            Experience = 10;
            Responsibilities = duties.Duty();
            GitHub = "https://github.com/RomanGarbutt";

            Console.WriteLine($"Full name: {FirstName} {LastName}, Experience: {Experience}, Title: " +
                $"{Architect}, Salary: {salary.ArchitectSalary}, GitHub: {GitHub}");
        }
        public void Employee4()
        {
            FirstName = "Lauryn";
            LastName = "Slater";
            ID = Guid.NewGuid();
            Experience = 5;
            Responsibilities = duties.Duty();
            GitHub = "https://github.com/LaurynSlater";

            Console.WriteLine($"Full name: {FirstName} {LastName}, Experience: {Experience}, Title: " +
                $"{SeniorDeveloper}, Salary: {salary.SeniorSalary}, GitHub: {GitHub}");
        }
        public void Employee5()
        {
            FirstName = "Vern";
            LastName = "Wootton";
            ID = Guid.NewGuid();
            Experience = 7;
            Responsibilities = duties.Duty();
            GitHub = "https://github.com/VernWootton";

            Console.WriteLine($"Full name: {FirstName} {LastName}, Experience: {Experience}, Title: " +
                $"{TeamLeader}, Salary: {salary.LeaderSalary}, GitHub: {GitHub}");
        }
        //Using List for Employee give me value "null"
    }
}