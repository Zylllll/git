using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0300Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口
            List<IFly> flies = new List<IFly>();
            Bird bird = new Bird();
            Plane plane = new Plane();
            SuperMan superman = new SuperMan();
            flies.Add(bird);
            flies.Add(plane);
            flies.Add(superman);

            foreach (IFly item in flies)
            {
                item.Fly();
            }
        }
    }
}
