using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300Interface
{
    public class SuperMan:IFly
    {
        public void Fly()
        {
            Console.WriteLine("超人举手就能飞！！！！！！有粑粑能量，而且还是热乎的能力，超乎你想象！！！");
        }
    }
}
