using System;

namespace HW03.Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char beg = '\x40';
            char end = '\x5A';

            for (char i = end; i > beg; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}