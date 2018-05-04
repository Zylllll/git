using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day08_0300xml
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 00.嵌套循环方式
            ////1. 在内存中构建一个空的文档对象
            //XmlDocument doc = new XmlDocument(); 
            ////2. Load可以从硬盘上载入一个xml文件
            //doc.Load("Books.xml");
            ////3. 获取xml文件的根节点
            //XmlNode root=doc.DocumentElement;
            //4. 
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    //一个item就是一个book节点
            //    foreach (XmlNode child in item.ChildNodes)
            //    {

            //        if (child.Name=="bookName")
            //        {
            //            Console.WriteLine("图书名称"+child.InnerText);
            //        }
            //        else if (child.Name == "bookPrice")
            //        {
            //            Console.WriteLine("图书价格" + child.InnerText);
            //        }

            //    }
            //    Console.WriteLine("===============End================");
            //} 
            #endregion

            #region 01.单层循环方案
            //1. 在内存中构建一个空的文档对象
            XmlDocument doc = new XmlDocument();
            //2. Load可以从硬盘上载入一个xml文件
            doc.Load("Books.xml");
            //3. 获取xml文件的根节点
            XmlNode root=doc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                //一个item代表一个book节点
                string bookid=item.Attributes["id"].Value.ToString();
                Console.WriteLine(bookid);
                Console.WriteLine("图书名称"+item["bookName"].InnerText);
                Console.WriteLine("图书价格"+item["bookPrice"].InnerText);
                Console.WriteLine("========================================");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
