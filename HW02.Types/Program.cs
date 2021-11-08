using System;

namespace HW02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 1;
            Console.WriteLine(a1.GetType());
            SByte a2 = 2;
            Console.WriteLine(a2.GetType());

            short a3 = 5;
            Console.WriteLine(a3.GetType());
            Int16 a4 = 6;
            Console.WriteLine(a4.GetType());

            int a5 = 7;
            Console.WriteLine(a5.GetType());
            Int32 a6 = 8;
            Console.WriteLine(a6.GetType());

            long a7 = 64;
            Console.WriteLine(a7.GetType());
            Int64 a8 = 45;
            Console.WriteLine(a8.GetType());

            byte a9 = 9;
            Console.WriteLine(a9.GetType());
            Byte a10 = 10;
            Console.WriteLine(a10.GetType());

            ushort a11 = 11;
            Console.WriteLine(a11.GetType());
            UInt16 a12 = 12;
            Console.WriteLine(a12.GetType());

            char a13 = 'B';
            Console.WriteLine(a13.GetType());
            Char a14 = 'b';
            Console.WriteLine(a14.GetType());

            uint a15 = 15;
            Console.WriteLine(a15.GetType());
            UInt32 a16 = 16;
            Console.WriteLine(a16.GetType());

            ulong a17 = 17;
            Console.WriteLine(a17.GetType());
            UInt64 a18 = 18;
            Console.WriteLine(a18.GetType());

            float a19 = 19;
            Console.WriteLine(a19.GetType());
            Single a20 = 20;
            Console.WriteLine(a20.GetType());

            double a21 = 21;
            Console.WriteLine(a21.GetType());
            Double a22 = 22;
            Console.WriteLine(a22.GetType());

            decimal a23 = 23;
            Console.WriteLine(a23.GetType());
            Decimal a24 = 24;
            Console.WriteLine(a24.GetType());

            object a25 = a1;
            Console.WriteLine(a25.GetType());
            Object a26 = a2;
            Console.WriteLine(a26.GetType());

            string a = "Hello";
            Console.WriteLine(a.GetType());
            String A = "Hello!";
            Console.WriteLine(A.GetType());
        }
    }
}