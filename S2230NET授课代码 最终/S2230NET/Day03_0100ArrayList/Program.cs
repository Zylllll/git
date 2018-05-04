using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0100ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 00--------单列集合ArrayList初步
            //定义一个容器，保存未知个数的字符串
            //ArrayList list = new ArrayList();
            ////添加元素
            //list.Add("牡丹");
            //list.Add("菊花");
            //list.Add("桃花");
            ////遍历
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////3.帮小鲍同学删除菊花
            //list.Remove("菊花");
            //list.RemoveAt(1);
            ////修改
            //list[0]="牡丹花";
            //Console.WriteLine("After remove===============");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 01.ArrayList补充-----------------
            //ArrayList list = new ArrayList();
            ////添加元素
            //list.Add("牡丹");
            //list.Add("菊花");
            //list.Add("桃花");
            //ctrl+K+S
            //list.Insert(2, "樱花");
            ////清除集合中所有元素
            //list.Clear();
            ////查看集合中       是否有      梨花
            //bool hasOrNotHas=list.Contains("梨花");
            //if (hasOrNotHas)
            //{
            //    Console.WriteLine("Has");
            //}
            //else
            //{
            //    Console.WriteLine("Not Has");
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 02.泛型集合中元素是对象类型
            //ArrayList list = new ArrayList();
            ////放入3本图书   书虫
            //Book b1 = new Book();
            //b1.BookName = "越狱";

            //Book b2 = new Book();
            //b2.BookName = "绿眼女子";
            //Book b3 = new Book();

            //b3.BookName = "偷窃";
            //list.Add(b1);
            //list.Add(b2);
            //list.Add(b3);

            ArrayList list = new ArrayList() 
            {
                new Book(){ BookName="越狱"},
                new Book(){BookName="绿眼女子"},
                new Book(){BookName="偷窃"}
            };

            foreach (Book item in list)
            {
                Console.WriteLine(item.BookName);
            }
            #endregion
            Console.ReadLine();

        }
    }
}
