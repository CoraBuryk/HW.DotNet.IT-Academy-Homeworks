using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14.Queue
{
    internal class Car
    {
        public string Name;
        static Random random = new Random();
        public int Year;

        public Car()
        {
            Name = Faker.Name.Last();
            Year = random.Next(1978, 2021);
        }
        public override string ToString()
        {
            return ($"{Name} {Year}");
        }
    }
}
