using System;

namespace HW08.Travaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write zipcode: ");
            string zipcode = Convert.ToString(Console.ReadLine());

            string adress1 = List.Travel("Main Street St. Louisville/123", "OH 43071:/");
            string adress2 = List.Travel("Main Long Road St. Louisville/432", "OH 43071:/");
            string adress3 = List.Travel("High Street Pollocksville/786", "NY 56432:/");

            switch (zipcode)
            {
                case "OH 43071:/":
                    Console.WriteLine(adress1);
                    Console.WriteLine(adress2);
                    break;

                case "NY 56432:/":
                    Console.WriteLine(adress3);
                    break;

                default:
                    Console.WriteLine(zipcode);
                    break;
            }
        }
    }
}