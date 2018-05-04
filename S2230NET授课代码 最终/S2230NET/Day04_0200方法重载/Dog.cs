using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0200方法重载
{
    public class Dog
    {
        public string DogName { get; set; }
        public Dog() { }
        public Dog(string dogname) 
        {
            DogName = dogname;
        }
        //public string bark()
        //{
        //    return "";
        //}

        //public void bark(string facetoSomeBody)
        //{
        //    Console.WriteLine("the dog with red hire barking" + facetoSomeBody);
        //}

        //列表不同 ：个数  顺序  类型 
        //public string bark(string facetoSomeBodyWhoFeeded)
        //{
        //    return "";
        //}

        //public void bark(string facetoSomeBody)
        //{
        //    Console.WriteLine("the dog with red hire barking" + facetoSomeBody);
        //}



    }
}
