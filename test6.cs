using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace UseArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("C#编程词典");
            list.Add("C#开发实战宝典");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}