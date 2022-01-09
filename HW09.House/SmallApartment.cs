using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09.House
{
    class SmallApartment : House
    {
        public SmallApartment()
                    : base(50)
        {

        }
        public override void ShowData()
        {
            Console.WriteLine($"I am an apartment, my area is {Area} m2");
        }
    }
}