using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.StudentAndTeacher
{
    class Teacher : Person
    {
        private string _subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
