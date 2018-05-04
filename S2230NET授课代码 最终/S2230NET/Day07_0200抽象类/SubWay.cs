using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200抽象类
{
    public class SubWay:Traffic
    {
        public override void Run()
        {
            Console.WriteLine("SuyWay Running.........");
        }

        public void BeenCleaned() { }
    }
}
