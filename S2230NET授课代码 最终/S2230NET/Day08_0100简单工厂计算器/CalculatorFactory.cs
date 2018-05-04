using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂计算器
{
    //根据国际标准，所有的工厂都应该以Factory为后缀
    public class CalculatorFactory
    {
        public static Calculator getInstance(string oper) 
        {
            Calculator cal = null;
            switch (oper)
            {
                case "+":
                    cal = new Add();
                    break;
                case "-":
                    cal = new Sub();
                    break;
                case "*":
                    cal = new Multi();
                    break;
                case "/":
                    cal = new Div();
                    break;
                default:
                    break;
            }
            return cal;
        }
    }
}
