using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0300对象间的交互
{
    class Program
    {
        static void Main(string[] args)
        {
            //买一辆车
            Car car = new Car();
            //买一个人
            Person p = new Person();
            p.DriverCar(car);


        }
    }
}
