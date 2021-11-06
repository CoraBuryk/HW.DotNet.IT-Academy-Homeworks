using System;

namespace HW05.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine($"Write the array's element: {i}");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("\t" + array[j]); // Выводит массив с последним элементом default
            }

            for (int k = 4; k < array.Length; k++)
            {
                Console.WriteLine("Write the last array's element: ");
                array[4] = int.Parse(Console.ReadLine()); // Выводит последний элемент
            }

            Console.WriteLine("Write the element's index: ");
            int index = int.Parse(Console.ReadLine()); // Индекс элемента 
        }
    }
}