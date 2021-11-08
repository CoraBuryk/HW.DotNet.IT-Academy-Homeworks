using System;

namespace HW05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer from 1 to 100: ");
            int height = int.Parse(Console.ReadLine());

            for (int weight = height; weight >= 0; weight--)
            {
                int c = 1;
                for (int i = height - weight; i >= 0; i--)
                {
                    for (i = c * 2 * weight + 1; i >= 0; i--)
                    {
                        Console.Write(" ");
                        Console.Write("{0:D}", weight);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}