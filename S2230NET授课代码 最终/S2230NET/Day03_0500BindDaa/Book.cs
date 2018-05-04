using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0500BindDaa
{
    public class Book
    {
        //底层会生成私有的字段  系统会对他进行命名
        public string BookName { get; set; }

        public int BookPrice { get; set; }

        public override string ToString()
        {
            return this.BookName;
        }
    }
}
