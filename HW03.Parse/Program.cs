using System;

namespace HW03.Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse("10");
            int b;
            Console.WriteLine("Write down a line");
            string str = Console.ReadLine();

            bool result = int.TryParse(str, out b);
            if (result)
                Console.WriteLine("Успешно" + b);
            else
                Console.WriteLine("Неудачно");
        }
    }
}