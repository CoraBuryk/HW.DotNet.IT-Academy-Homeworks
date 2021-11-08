using System;
using System.Diagnostics;

namespace HW05.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            long[] res1 = new long[100];
            Random random1 = new Random();
            for (int i = res1.Length - 1; i > 0; i--)
            {
                res1[i] = random1.Next(100_000);
                Console.WriteLine(res1[i]);
            }
            stopwatch1.Stop();
            Console.WriteLine(stopwatch1.Elapsed);

            // Reverse работает быстрее

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            long[] res2 = new long[100];
            Random random2 = new Random();
            for (int j = 0; j < res2.Length; j++)
            {
                Array.Reverse(res2);
                res2[j] = random2.Next(100_000);
                Console.WriteLine(res2[j]);
            }
            stopwatch2.Stop();
            Console.WriteLine(stopwatch2.Elapsed);
        }
    }
}