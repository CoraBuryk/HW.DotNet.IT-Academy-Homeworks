using System;

namespace HW03.Move
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    Console.WriteLine("Enter a symbol to move the character");
                    string sym = Console.ReadLine().ToLower();

                    switch (sym)
                    {
                        case "w":
                            Console.WriteLine("Moving up");
                            break;

                        case "s":
                            Console.WriteLine("Moving down");
                            break;

                        case "a":
                            Console.WriteLine("Moving right");
                            break;

                        case "d":
                            Console.WriteLine("Moving left");
                            break;

                        default:
                            Console.WriteLine("Not moving");
                            break;
                    }
                    Console.Write("Press any key... ");
                    Console.ReadLine();
                }
            }
        }
    }
}