using System;

namespace HW06.Poem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write a poem with ';' after every string :");
            foreach (string str in Console.ReadLine().Replace('o', 'a').Split(';'))
                Console.WriteLine(str ?? "");
        }
    }
}