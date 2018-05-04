using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200hasConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(23,"张靓颖","职业陪练");




            Console.WriteLine(child.HomeAddress);
            Console.WriteLine(child.Name);
            Console.WriteLine(child.Age.ToString());
        }
    }
}
