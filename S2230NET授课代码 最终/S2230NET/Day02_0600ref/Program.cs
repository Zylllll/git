using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0600ref
{
    class Program
    {
        //referrences ：引用
        static void ChangeNum(ref int num1,ref  int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            //Console.WriteLine("交换方法内部{0}\t{1}", num1, num2);
        }
        static void Main(string[] args)
        {
            #region 01.引用传递传递值类型  结论：值的更改会保留
            //int num1 = 5;
            //int num2 = 10;
            //ChangeNum(ref num1, ref num2);
            //Console.WriteLine("{0}\t{1}", num1, num2);
            //Console.ReadLine(); 
            #endregion


            #region 02.值传递（参数没有ref） 传递引用类型（用户自定义类型 Student）
            //找一个学生对象
            Student stu = new Student();
            stu.Age = 18;
            //用一个方法，更改学生的年龄
            ChangeStudentAge(stu);

            //打印输出学生的年龄
            Console.WriteLine(stu.Age);
            Console.ReadLine();
            #endregion
        }
        static void ChangeStudentAge(Student stu)//Student stu=stu;
        {
            stu.Age=22;
        }
    }
}
