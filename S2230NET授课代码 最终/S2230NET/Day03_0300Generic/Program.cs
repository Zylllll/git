using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0300Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 00.泛型的引子
            //ArrayList list = new ArrayList();
            //PM pm = new PM();

            //SE se1 = new SE();
            //SE se2 = new SE();

            //list.Add(pm);
            //list.Add(se1);
            //list.Add(se2);

            //foreach (Object item in list)
            //{
            //    SE se = (SE)item;//为了说明泛型  而写的一个例子
            //}
            
            #endregion


            #region 01.List<T>  存储3本 图书对象  
            //List<Book> list = new List<Book>()
            //{
            //    new Book(){BookName="朝花夕拾",BookPrice=32},
            //    new  Book(){BookName="四世同堂",BookPrice=45}
            //};
            //List<Book> list = new List<Book>();
            //Book b1 = new Book();
            //b1.BookName = "朝花夕拾";
            //b1.BookPrice = 32;
            //list.Add(b1);

            //foreach (Book item in list)
            //{
            //    Console.WriteLine(item.BookName);
            //}
            //Console.WriteLine("=============分割线====");
            ////集合中元素总个数   用Count  数组长度用Length，集合长度用Count
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].BookName);
            //}

            #endregion


            #region 02.双列泛型  Dictionary<K,V>   添加三本图书 ，图书名称作为key，图书对象作为value
            Dictionary<string, Book> dic = new Dictionary<string, Book>();

            Book b1 = new Book();
            b1.BookName = "朝花夕拾";
            b1.BookPrice = 32;

            Book b2 = new Book();
            b2.BookName = "四世同堂";
            b2.BookPrice = 52;

            dic.Add(b1.BookName, b1);

            dic.Add(b2.BookName, b2);

            //方式一：通过key遍历value
            foreach (string key in dic.Keys)
            {
                Console.WriteLine(key+"\t"+dic[key]);    
            }
            Console.WriteLine("====================分割线");
            //方式二：直接遍历value
            foreach (Book value in dic.Values)
            {
                Console.WriteLine(value);  // 朝花夕拾   四世同堂
            }
            //方式三：key+value同时遍历
            foreach (KeyValuePair<string,Book> item in dic)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            
            //减轻代码量  
          

            #endregion 
            Console.ReadLine();
        }
    }
}
