using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300Interface
{
    public class Plane:IFly
    {
        public void Fly()
        {
            Console.WriteLine("马航飞走了，但是再也没有回来了");
        }
    }
}
