using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0300对象间的交互
{
    public class Person
    {
       
        public void DriverCar(Car car) 
        {
            car.Run();
        }
    }
}
