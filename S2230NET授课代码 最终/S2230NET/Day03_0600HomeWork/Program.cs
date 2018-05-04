using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day03_0600HomeWork
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #region 01单列的例子
            //Student s1=new Student(){StuName="张靓颖",StuAge=22};
            ////对象初始化器
            //Student s2 = new Student() { StuName = "张靓颖2", StuAge = 32 };
            //Student s3 = new Student() { StuName = "张靓颖3", StuAge = 42 };
            //List<Student> list=new List<Student>();
            //list.Add(s1);
            //list.Add(s2);
            //list.Add(s3);
            //list.Remove(s2);
            //foreach (var item in list)
            //{

            // Console.WriteLine(item.StuName); 
            //} 
            #endregion


            #region 02.双列集合
             Student s1=new Student(){StuName="张靓颖",StuAge=22};
            //对象初始化器
            Student s2 = new Student() { StuName = "张靓颖2", StuAge = 32 };
            Student s3 = new Student() { StuName = "张靓颖3", StuAge = 42 };
            Dictionary<string, Student> dic = new Dictionary<string, Student>();
            dic.Add(s1.StuName,s1);
            dic.Add(s2.StuName, s2);
            dic.Add(s3.StuName, s3);

            //Student stu=dic["张靓颖2"];
            //Console.WriteLine(stu.StuName);
            dic.Remove(s2.StuName);

            foreach (KeyValuePair<string,Student> item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.StuName);

            }
            #endregion



        }
    }
}
