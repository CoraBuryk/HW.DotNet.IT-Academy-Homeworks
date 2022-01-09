using System;
using System.Collections.Generic;
using System.Linq;

namespace HW06.Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                string str1 = " ";
                int num1 = 0;
                int num2 = 0;
                string str2 = " ";
                int index1 = int.MaxValue;
                Console.WriteLine("Write a string: ");
                string str3 = Console.ReadLine();
                for (int index2 = 0; index2 < str3.Length; ++index2)
                {
                    //string[] strArray = str3.Split(' ');
                    List<string> strArray = new List<string>(str3.Split(' '));
                    if (strArray.Count > num1)
                    {
                        num1 = strArray[index2].Length;
                        num2 = index2;
                        str1 = strArray[index2];
                    }
                }
                Console.WriteLine(str3.Replace(str1 ?? "", " "));
                for (int index3 = 0; index3 < str3.Length; ++index3)
                {
                    //string[] strArray = str3.Split(' ');
                    List<string> strArray = new List<string>(str3.Split(' '));
                    if (strArray.Count > num1)
                    {
                        num1 = strArray[index3].Length;
                        num2 = index3;
                        str1 = strArray[index3];
                    }
                    for (int index4 = 1; index4 < str3.Length; ++index4)
                    {
                        if (strArray.Count < index1)
                        {
                            index1 = strArray[index4].Length;
                            str2 = strArray[index1];
                        }
                    }
                }
                Console.WriteLine(str3.Replace(str1 ?? "", str2 ?? "") + str3.Replace(str2 ?? "", str1 ?? ""));
                for (int index5 = 0; index5 > str3.Length; ++index5)
                    Console.WriteLine(str3.Replace(" ", "").Count<char>());
                //string[] array = str3.Split(' ');
                List<string> array = new List<string>(str3.Split(' '));
                array.OrderBy<string, int>((Func<string, int>)(x => x.Length)).ToList();
                array.Reverse();
                //Array.Sort<string>(((IEnumerable<string>)array).OrderBy<string, int>((Func<string, int>)(x => x.Length)).ToArray<string>());
                //Array.Reverse<string>(array);
                foreach (string str4 in array)
                    Console.WriteLine(str4);
            }
        }
    }
}