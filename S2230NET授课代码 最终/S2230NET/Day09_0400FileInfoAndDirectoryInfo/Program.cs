using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_0400FileInfoAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.FileInfo
            //string path = "E:\\正则.txt";
            //FileInfo info = new FileInfo(path);
            ////文件名字
            //Console.WriteLine("名称:" + info.Name); //正则.txt
            //Console.WriteLine("全名称" + info.FullName);//E:\\正则.txt
            //Console.WriteLine("文件大小："+info.Length*1.0/1024+"kb");
            //Console.WriteLine("文件后缀：" + info.Extension);  //扩展名  或追
            //后缀名称

           
            #endregion


            #region 02.DirectoryInfo  获取目录信息 
            DirectoryInfo dirctory = new DirectoryInfo("E:\\云台花园");
            FileInfo[] files=dirctory.GetFiles();
            foreach (FileInfo item in files)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("================================");
            //获取所有文件夹集合
            DirectoryInfo[] dics=dirctory.GetDirectories();
            foreach (DirectoryInfo item in dics)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
            #endregion

        }
    }
}
