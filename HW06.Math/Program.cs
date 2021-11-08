using System;
using System.Linq;

namespace HW06.Math
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write strings: ");
            string str1 = Convert.ToString(Console.ReadLine());
            if (str1.Contains('+'))
            {
                string str2 = str1;
                int index = 0;
                if (index >= str2.Length)
                    return;
                int num = (int)str2[index];
                string[] strArray = str1.Split('+');
                string s1 = new string(strArray[0].Where<char>((Func<char, bool>)(t => char.IsDigit(t))).ToArray<char>());
                string s2 = new string(strArray[1].Where<char>((Func<char, bool>)(q => char.IsDigit(q))).ToArray<char>());
                Console.WriteLine(int.Parse(s1) + int.Parse(s2));
            }
            else if (str1.Contains('-'))
            {
                string str3 = str1;
                int index = 0;
                if (index >= str3.Length)
                    return;
                int num = (int)str3[index];
                string[] strArray = str1.Split('-');
                string s3 = new string(strArray[0].Where<char>((Func<char, bool>)(t => char.IsDigit(t))).ToArray<char>());
                string s4 = new string(strArray[1].Where<char>((Func<char, bool>)(q => char.IsDigit(q))).ToArray<char>());
                Console.WriteLine(int.Parse(s3) - int.Parse(s4));
            }
            else if (str1.Contains('*'))
            {
                string str4 = str1;
                int index = 0;
                if (index >= str4.Length)
                    return;
                int num = (int)str4[index];
                string[] strArray = str1.Split('*');
                string s5 = new string(strArray[0].Where<char>((Func<char, bool>)(t => char.IsDigit(t))).ToArray<char>());
                string s6 = new string(strArray[1].Where<char>((Func<char, bool>)(q => char.IsDigit(q))).ToArray<char>());
                Console.WriteLine(int.Parse(s5) * int.Parse(s6));
            }
            else
            {
                if (!str1.Contains('/'))
                    return;
                string str5 = str1;
                int index = 0;
                if (index < str5.Length)
                {
                    int num = (int)str5[index];
                    string[] strArray = str1.Split('/');
                    string s7 = new string(strArray[0].Where<char>((Func<char, bool>)(t => char.IsDigit(t))).ToArray<char>());
                    string s8 = new string(strArray[1].Where<char>((Func<char, bool>)(q => char.IsDigit(q))).ToArray<char>());
                    Console.WriteLine(int.Parse(s7) / int.Parse(s8));
                }
            }
        }
    }
}