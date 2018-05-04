using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0100构造
{
    class Program
    {
        static void Main(string[] args)
        {
            //无参构造赋值
            Student stu = new Student();
            stu.Name = "张三";
            stu.Age = 20;
            //带参构造
            Student stu2 = new Student("李四", 22);
        }
    }
}
