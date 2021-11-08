using System;

namespace HW02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion

            int num1 = 5;
            float num2 = num1;
            Console.WriteLine(num2);

            sbyte num3 = 125;
            short num4 = num3;
            Console.WriteLine(num4);

            int num5 = 1_000_650;
            long num6 = num5;
            Console.WriteLine(num6);

            float num7 = 446;
            double num8 = num7;
            Console.WriteLine(num8);

            ulong num9 = 78_852_987;
            decimal num10 = num9;
            Console.WriteLine(num10);

            // explicit conversion

            double num11 = 5.3;
            float num12 = (float)num11;
            Console.WriteLine(num12);

            long num13 = -4569;
            int num14 = (int)num13;
            Console.WriteLine(num14);

            string str1 = "98";
            int num15 = Convert.ToInt32(str1);
            Console.WriteLine(num15);

            int num16 = 88_457;
            short num17 = (short)num16;
            Console.WriteLine(num17);

            decimal num18 = 4_294_967_295;
            uint num19 = (uint)num18;
            Console.WriteLine(num19);

            //boxing && unboxing

            int num20 = 10;
            Object obj1 = num20;
            int num24 = (int)obj1;

            long num25 = -888_945_741;
            Object obj2 = num25;
            int num26 = (int)Convert.ToInt64(obj2);

            int num21 = 0;
            Object obj3 = num21;
            num21 += (int)obj3;

            short num27 = 7;
            Object obj4 = num27;
            sbyte num28 = (sbyte)Convert.ToSByte(obj4);

            byte num29 = 68;
            Object obj5 = num29;
            short num30 = (short)Convert.ToInt16(obj5);

            int num23 = default;
            num23.GetType();
        }
    }
}