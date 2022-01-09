using System;

namespace HW09.House
{
    class Program
    {
        static void Main()
        {
            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "Tom";
            myPerson.House = mySmallApartament;
            myPerson.ShowData();
        }
    }
}