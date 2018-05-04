using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100简单工厂计算器
{
   public class Div:Calculator
    {
       public override int Calc()
       {
           if (NumRight==0)
           {
               //除数为0 
               //程序中如何抛出异常
               throw new Exception("除数不能为0");
           }
           else 
           {
               return this.NumLeft / this.NumRight;
           }
           
       }
    }
}
