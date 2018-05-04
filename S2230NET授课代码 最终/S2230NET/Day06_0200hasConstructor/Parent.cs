using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200hasConstructor
{
    public class Parent
    {
        //私有字段
        private int age;
        private string name;

        //构造 
        public Parent() { }

        public Parent(string name,int age)
        {
            this.age = age;
            this.name = name;
        }

        public void SayHello() { }


        //系统方法




        //属性


        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

}
