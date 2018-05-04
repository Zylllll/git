using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0200ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //小龙和小明去年身高都是170cm，
            int xiaolong = 170;
            int xiaoming=xiaolong;
             //输出去年
            Console.WriteLine("去年小龙的身高是{0},小明的身高是{1}",xiaolong,xiaoming);
            //今年小明长到了180cm，小龙没有变化，
            xiaoming = 180;
           //和今年两人身高
            Console.WriteLine("今年小龙的身高是{0},小明的身高是{1}", xiaolong, xiaoming);
            Console.ReadLine();
        }
    }
}
