using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0200单例
{
    public class Dog
    {
        private static Dog onlyOne;  //保存该类型的唯一对象
        private Dog() { }
        public static Dog getInstance() 
        {
            if (onlyOne == null)
            {
                onlyOne = new Dog();
            }
            return onlyOne;
        }
    }
}
