using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0100构造
{
   public class Book
    {
       public string BookName { get; set; }
       //无参构造
       //01.定义一个空类，编译器会在底层做代码补全，代码补全一个无参构造

       //02.如果程序员在类中显示的定义了任何一款构造，那么底层编译器不会再补全无参构造

       //03.一个类可以有1到N个构造，N是没有上限的。

       //04.构造的作用：初始化成员变量
       public  Book()
       {

       }
       public Book(string bookName)
       {
           this.BookName = bookName;
       }
       public Book(int bookPrice)
       {
           
       }
    }
}
