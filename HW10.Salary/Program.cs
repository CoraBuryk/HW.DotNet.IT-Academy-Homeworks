using System;
using System.Collections.Generic;
using System.Linq;

namespace HW10.Salary
{
    class Program
    {
        static void Main()
        {
            Characters characters = new Characters();
            List list = new List();
            Console.WriteLine($"Company: {characters.CompanyName}, ");

            list.Employee1();
            list.Employee2();
            list.Employee3();
            list.Employee4();
            list.Employee5();
        }
    }
}