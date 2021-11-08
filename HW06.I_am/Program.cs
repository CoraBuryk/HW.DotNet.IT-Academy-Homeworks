using System;
using System.Diagnostics;

namespace HW06.I_am
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Console.WriteLine("I am" + 18.ToString() + ".");
            stopwatch1.Stop();
            Console.WriteLine((object)stopwatch1.Elapsed);
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Console.WriteLine("I am" + 18.ToString() + ".");
            stopwatch2.Stop();
            Console.WriteLine((object)stopwatch2.Elapsed);
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            Console.WriteLine(string.Format("I am {0}.", (object)18));
            stopwatch3.Stop();
            Console.WriteLine((object)stopwatch3.Elapsed);
        }
    }
}