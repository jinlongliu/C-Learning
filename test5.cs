using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OutDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string strB = string.Format("{0:D}", dt);
            Console.WriteLine(strB);
            Console.ReadLine();
        }
    }
}