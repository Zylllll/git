using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300Interface
{
    public class Bird:Animal,IFly,IRun
    {
        public void Fly()
        {
            Console.WriteLine("小鸟张开翅膀高兴的在天空中飞来飞去");
        }

        public void Run()
        {
            Console.WriteLine("小鸟跑");
        }

        public override void Sleep()
        {
            Console.WriteLine("Bird Sleep");
        }
    }
}
