using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0400多态
{
    public class Chinese:Person
    {
        public override void SayHello() 
        {
            Console.WriteLine("您好");
        }
    }
}
