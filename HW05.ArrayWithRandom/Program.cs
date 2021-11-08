using System;

namespace HW05.ArrayWithRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array with Random:");

            int[] randomArray = new int[5];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(100);
                Console.WriteLine(randomArray[i]);
            }

            Console.WriteLine("Array with typesetting: ");

            int[] typeArray = new int[5];
            for (int j = 0; j < typeArray.Length; j++)
            {
                Console.WriteLine($"Type array element {j}: ");
                typeArray[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of two arrays: ");

            int[] sumArray = new int[typeArray.Length];
            for (int k = 0; k < sumArray.Length; k++)
            {
                if (k < randomArray.Length)
                {
                    sumArray[k] = typeArray[k] + randomArray[k];
                    Console.WriteLine(sumArray[k]);
                }
                else
                    Console.WriteLine(" ");
            }
        }
    }
}