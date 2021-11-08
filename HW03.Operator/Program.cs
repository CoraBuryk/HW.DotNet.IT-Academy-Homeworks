using System;

namespace HW03.Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Amount();
        }
        private static void Amount()
        {

            while (true)
            {
                double num1, num2, sum, sub, total;
                num1 = 0;
                num2 = 0;
                sum = 0;
                sub = 0;
                total = 0;
                string sing;
                try
                {
                    Console.Write("Enter a number 1: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter a number 2: ");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Write down a number!");
                    continue;
                }

                Console.Write("Choose + or - ");
                sing = Console.ReadLine();

                switch (sing)
                {
                    case "+":
                        sum = num1 + num2;
                        break;
                    case "-":
                        sub = num1 - num2;
                        break;
                    default:
                        Console.WriteLine("Wrong sing");
                        continue;
                        break;
                }

                try
                {
                    Console.Write("Total ");
                    total = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Write down a number!");
                    continue;
                }

                if (total == sum || total == sub)
                {
                    Console.WriteLine("You are right!");
                    Console.WriteLine("Good job!");
                }
                else

                if (total < sum || total < sub)
                {
                    Console.WriteLine("You are wrong!");
                    Console.WriteLine("It should be more");
                }
                else
                    if (total > sum || total > sub)
                {
                    Console.WriteLine("You are wrong!");
                    Console.WriteLine("It should be less");
                }
                else
                    Console.WriteLine("Good job!");

                Console.Write("Press any key... ");
                Console.ReadLine();
            }
        }
    }
}