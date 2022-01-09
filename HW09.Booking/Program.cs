using System;
using System.Collections.Generic;
using HW09.Booking.Models;


namespace HW09.Booking
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Login login = new Login();
                Console.WriteLine("Registration page");

                Console.WriteLine("What is your name?");
                login.Name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Your e-mail adress: ");
                login.Email = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Create a password: ");
                login.Password = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Thank you for registration!");
                Console.WriteLine($"Your name is {login.Name}. Your e-mail is {login.Email}.");

                Search search = new();
                Console.WriteLine($"Where do you go for a trip? {string.Join(",", search.Country)}?");

                search.Destination = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Date of check in: ");
                search.CheckIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Date of check out: ");
                search.CheckOut = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("How many people will go?");
                search.NumberOfPerson = Convert.ToInt16(Console.ReadLine());

                Book book = new();
                Purchase purchase = new();

                switch (search.Destination)
                {
                    case "Egypt":
                        Console.WriteLine($"Choose a hotel: {string.Join(",", book.HotelEgypt)}");
                        break;

                    case "Greece":
                        Console.WriteLine($"Choose a hotel: {string.Join(",", book.HotelGreece)}");
                        break;

                    case "France":
                        Console.WriteLine($"Choose a hotel: {string.Join(",", book.HotelFrance)}");
                        break;

                    case "England":
                        Console.WriteLine($"Choose a hotel: {string.Join(",", book.HotelEngland)}");
                        break;

                    case "Turkey":
                        Console.WriteLine($"Choose a hotel: {string.Join(",", book.HotelTurkey)}");
                        break;

                    default:
                        Console.WriteLine("Choose another destination");
                        break;
                }

                book.Hotel = Convert.ToString(Console.ReadLine());

                int price = 0;
                switch (book.Hotel)
                {
                    case "Sunny Days":
                        price = search.NumberOfPerson * purchase.CostSunnyDay * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Moon Hotel":
                        price = search.NumberOfPerson * purchase.CostMoonHotel * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Panarama Resort":
                        price = search.NumberOfPerson * purchase.CostPanaramaResort * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Old Town":
                        price = search.NumberOfPerson * purchase.CostOldTown * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Hellenic House":
                        price = search.NumberOfPerson * purchase.CostHellenicHouse * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Komissa Beach":
                        price = search.NumberOfPerson * purchase.CostKomissaBeach * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Temple Apartments":
                        price = search.NumberOfPerson * purchase.CostTempleApartments * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Guest House":
                        price = search.NumberOfPerson * purchase.CostGuestHouse * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "La Rappe":
                        price = search.NumberOfPerson * purchase.CostLaRappe * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Americana Hotel":
                        price = search.NumberOfPerson * purchase.CostAmericanaHotel * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Paskins House":
                        price = search.NumberOfPerson * purchase.CostPaskinsHouse * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Woodthorpe":
                        price = search.NumberOfPerson * purchase.CostWoodthorpe * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Nova Plaza":
                        price = search.NumberOfPerson * purchase.CostNovaPlaza * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Magnova Studios":
                        price = search.NumberOfPerson * purchase.CostMagnovaStudios * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    case "Hich Konya":
                        price = search.NumberOfPerson * purchase.CostHichKonya * (search.CheckOut.Day - search.CheckIn.Day);
                        Console.WriteLine($"Your price for weekend {price} $");
                        break;

                    default:
                        Console.WriteLine("Choose another hotel");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}