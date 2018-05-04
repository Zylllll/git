using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果定义一个小数，前面的类型是float,必须显示的加上后缀f，否则编译器会认为你定义 
            //所有的小数默认都是double类型
            double number = 1.0;
            float num = 1.0f;
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
