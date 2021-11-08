using System;

namespace HW03.Calculator
{
    class Calculator
    {
        static int SUM(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Total {0}", result);
        }

        static int SUB(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }

        static int MUL(int num1, int num2)
        {
            int mul = num1 * num2;
            return mul;
        }

        static int DIV(int num1, int num2)
        {
            int div = num1 / num2;
            return div;
        }

        static int RESI(int num1, int num2)
        {
            int resi = num1 * num2;
            return resi;
        }

        static double AREA(double num1)
        {
            double area = Math.PI * num1;
            return area;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                // sum - сложение, sub - вычитание, mul - умножение, div - деление, area - площадь круга, resi - остаток от деления
                int num1, num2, sum, sub, mul, div, resi;
                double area;
                string sing;

                Console.Write("Choose '+', '-', '*',  '/', '%', 'S': ");
                sing = Console.ReadLine();

                switch (sing)
                {
                    case "+":
                        Console.Write("Enter a number 1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        sum = SUM(num1, num2);
                        PrintResult(sum);
                        break;
                    case "-":
                        Console.Write("Enter a number 1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        sub = SUB(num1, num2);
                        PrintResult(sub);
                        break;
                    case "*":
                        Console.Write("Enter a number 1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        mul = MUL(num1, num2);
                        PrintResult(mul);
                        break;
                    case "/":
                        Console.Write("Enter a number 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        div = DIV(num1, num2);
                        PrintResult(div);
                        break;
                    case "%":
                        Console.Write("Enter a number 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        num2 = int.Parse(Console.ReadLine());

                        resi = RESI(num1, num2);
                        PrintResult(resi);
                        break;
                    case "S":
                        Console.Write("Enter a number 1: ");
                        num1 = int.Parse(Console.ReadLine());

                        area = AREA(num1);
                        PrintResult((int)area);
                        break;
                    default:
                        Console.Write("Wrong sing");
                        break;
                }
                Console.Write("Press any key... ");
                Console.ReadLine();
            }
        }
    }
}