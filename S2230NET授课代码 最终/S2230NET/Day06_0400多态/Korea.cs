using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0400多态
{
    //韩国人
    public class Korea : Person
    {
        public override void SayHello() 
        {
            Console.WriteLine("金喜善打招呼的方法");
        }
    }

}
