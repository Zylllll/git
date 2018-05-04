using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_0300静态不能使用对象调度
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.bookName = "XXXX";
        }
    }
}
