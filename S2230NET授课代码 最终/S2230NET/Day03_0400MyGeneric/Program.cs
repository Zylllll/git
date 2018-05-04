using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0400MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> list = new MyGeneric<int>();
            list.r = 2;

            MyGeneric<string> listString = new MyGeneric<string>();
            listString.r = "2";

            MyGeneric<int[]> listArray = new MyGeneric<int[]>();
            listArray.r = new int[3];


            MyGeneric<Dog> listDog = new MyGeneric<Dog>();
            listDog.r = new Dog();


            MyGeneric<Dictionary<string, Dog>> listDictionaryDog = new MyGeneric<Dictionary<string, Dog>>();
            Dictionary<string, Dog> dic = new Dictionary<string, Dog>();
            listDictionaryDog.r = dic;

        }
    }
}
