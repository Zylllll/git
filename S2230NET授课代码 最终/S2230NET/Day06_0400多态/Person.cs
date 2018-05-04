using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0400多态
{
    public class Person
    {
        //VR:虚拟现实  Virtual  Real 
        //AI 人工智能  Python 开发
        //BigData  大数据
        //CloudCalculator 云计算
        //区块链：
        public virtual void SayHello() 
        {
            Console.WriteLine("父类打招呼的方法");
        }
    }
}
