using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂计算器
{
    public abstract class Calculator
    {
        private int numLeft;
        private int numRight;

        public abstract int Calc();
        public int NumLeft
        {
            get { return numLeft; }
            set { numLeft = value; }
        }
       

        public int NumRight
        {
            get { return numRight; }
            set { numRight = value; }
        }



    }
}
