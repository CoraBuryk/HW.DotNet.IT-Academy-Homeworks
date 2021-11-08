using System;

namespace HW08.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sting: ");
            string str = Convert.ToString(Console.ReadLine());
            string str1 = str.Substring(0, str.IndexOf('?'))
                            .Replace("!", string.Empty).Replace(".", string.Empty);
            string str2 = str.Substring(str.IndexOf('?')).Replace(' ', '_');
            Console.WriteLine(string.Concat(str1, str2));
        }
    }
}