using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0400Struct
{
    /*
     *      /*01.结构体不用new,就可以直接对其属性赋值
             *02.结构体中可以有字段,属性和方法
             *03.结构体是值类型,类是引用类型
             *04.在结构体中不能给字段赋初值,但是类中可以.
             *05.结构体中没有默认构造函数,但类中有默认构造函数
     *
     *    结构体也是一种数据类型，并且是值类型
     *    空类在底层系统会生成构造，但是结构体不会
     */
    public struct MyStruct
    {
        public int age=12;//错误做法
        public string name;
        public void SayHello() 
        {
            Console.WriteLine("我是Hello方法");
        }
    }
}
