using System;

namespace HW02.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаются переменные a,b,c, которые вводятся ползователем на консоли
            Console.Write("a = ");
            // Convert.ToInt32 - преобразует заданное значение в 32-битовое целое число со знаком.
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            // Math.Pow - степень в C#
            double dis = Math.Pow(b, 2) - (4 * a * c);

            if (dis < 0) Console.WriteLine("Корень не найден");
            else
            {
                // Math.Sqrt - квадратный корень 
                int x1 = (int)(-(b - Math.Sqrt(dis)) / (2 * a));
                int x2 = (int)(-(b + Math.Sqrt(dis)) / (2 * a));
                // == - знак равенства; 
                if (x1 == x2) Console.WriteLine("Корень один x= ", x1);
                else Console.WriteLine("Два корня x1={0}; x2={1}", x1, x2);
            }
        }
    }
}