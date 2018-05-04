using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0500BoxAndUnBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;
            //Object obj = num;  //装箱操作
            //int result = (int)obj; //拆箱操作

            int number = 3;
            Console.WriteLine(number.ToString()); //有吗？结论：没有发生装箱

        }
    }
}
