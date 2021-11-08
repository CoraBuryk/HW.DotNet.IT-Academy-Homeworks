using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The date of your birth (year and mounth): ");
            DateTime date_bir = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Today's date (year and mounth): ");
            DateTime date_now = Convert.ToDateTime(Console.ReadLine());

            if (date_bir <= date_now)
            {
                string age = Convert.ToString(date_now.Year - date_bir.Year);
                Console.WriteLine(age);
            }
        }
    }
}