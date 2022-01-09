using System;

namespace HW05.GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan dateNow = DateTime.Now.TimeOfDay;
            int hours = dateNow.Hours;

            switch (hours)
            {
                case (>= 9) when hours < 12:
                    Console.WriteLine(dateNow + " Good morning,guys");
                    break;
                case (>= 12) when hours < 15:
                    Console.WriteLine(dateNow + " Good day,guys");
                    break;
                case (>= 15) when hours < 22:
                    Console.WriteLine(dateNow + " Good evening,guys");
                    break;
                default:
                    Console.WriteLine(dateNow + " Good night, guys");
                    break;
            }
        }
    }
}