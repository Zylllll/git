using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0400Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct ss;
            ss.age = 12;
            ss.name = "张三";
            ss.SayHello();
            Console.ReadLine();
        }
    }
}
