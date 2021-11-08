using System;
using System.IO;
using System.Globalization;
using System.Linq;

namespace HW06.FindMe
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader TextReader = new StreamReader(@"C:\Users\vovab\Downloads\FindMe.txt", true);
            string textReaderResult = TextReader.ReadToEnd();
            TextReader.Dispose();
            string[] array = textReaderResult.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                string arr = array[i];
                char s = '\u001f';
                char control = (char)i;
                if (control == s)
                {
                    int num = Convert.ToInt32(array[i].Count());
                    Console.WriteLine($"Control character {s} found {num} number of times");
                    int value = Convert.ToInt32(s);
                    string hexOutput = String.Format("{0:X}", value);
                    Console.WriteLine("Hexadecimal value of {0} is {1}", s, hexOutput);
                }
            }
        }
    }
}