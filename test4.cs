using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#从基础到项目实战";
            string str2 = "C#编程词典";
            Console.WriteLine(string.Compare(str1, str2));
            Console.WriteLine(string.Compare(str1, str1));
            Console.WriteLine(string.Compare(str2, str1));
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(string.Equals(str1, str2));
            Console.ReadLine();
        }
    }
}