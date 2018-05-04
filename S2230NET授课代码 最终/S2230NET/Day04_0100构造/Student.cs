using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0100构造
{
   public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        //两个构造
       public Student() 
       {
       }
       public Student(string name,int age)
       {
           this.Name = name;
           this.Age = age;
       }

    }
}
