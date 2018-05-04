using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200抽象类
{
    //抽象类的特点：
    /*
     1.抽象类不能实例化
     2.抽象方法只能出现在抽象类中
     3.抽象方法不能有方法体，直接以分号结束，甚至连{}都不能有
     4.抽象方法是用来约束子类同名方法的方法形式的
     5.抽象类中的所有抽象方法，子类都必须强制重写，除非子类本身也是一个抽象类
     6.抽象类不能是静态类密封类(sealed):没有子类
     7.抽象类中可以有普通方法
     8.抽象类有构造函数 
     * 
     */
    public abstract class Traffic
    {
        public Traffic() { }
        public void Say() { }
        
        public abstract void Run();
    }
}
