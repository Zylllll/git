using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂计算器
{
    public class Add:Calculator
    {
        public override int Calc()
        {
            return this.NumLeft + this.NumRight;
        }
    }
}
