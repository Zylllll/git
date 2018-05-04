using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Traffic tool = new Car();

            emp.GoHome(tool);

           
           //学习使我快乐
            //代码没有运行的时候，如果写法是父类  父类变量 =new  子类();  父类变量点出来的方法表都是父类的

           
        }
    }
}
