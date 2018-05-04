using System;
using System.Collections.Generic;
//导入IO命名空间        Input   和  Output  输入/输出流
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_0100WriterText
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.写入文本文件
             //WriteToFile();
            #endregion

            #region 02.读取文本文件
                //ReadDataFromFile();
            #endregion

            #region 03.文件操作

            //判定文件是否存在
            //bool flag= File.Exists("E:\\晚自习.txt");
            //if (flag)
            //{
            //    Console.WriteLine("文件存在");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}
            ////Copy
            ////File.Copy("E:\\cgy.jpg", "D:\\柴光亚.jpg");

            ////Move  剪切
            //if (!File.Exists("D:\\柴光亚.jpg"))
            //{
            //    File.Move("E:\\cgy.jpg", "D:\\柴光亚.jpg");
            //}
            ////删除
            //File.Delete("D:\\2140年比特币数量为0.txt");

            #endregion

            #region 04.文件夹操作
            Directory.Delete("E:\\小电影",true);
            Console.WriteLine("大爷，删除成功！");
            //FileStream fs = new FileStream("E:\\111.txt", FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("我怎么听到有人说话，现在有苍蝇吗？");
            //sw.Flush();
            ////我就是不调度Close()，我还想实现内容写入，有什么方案？
            //Console.WriteLine("xxxxx");
            #endregion

            #region 05.静态操作

            #endregion
          

            Console.ReadKey();
        }
        //1.读取文本文件
        private static void ReadDataFromFile()
        {
            FileStream fs = new FileStream("E:\\晚自习.txt",FileMode.Open); //文件存在，打开文件读取
            //02.创建读取器
            StreamReader sr = new StreamReader(fs,Encoding.GetEncoding("gbk"));
            //3.读取操作
            //string words=sr.ReadToEnd();
            //循环读取 每次读取一行
            string data=string.Empty;
            while ((data=sr.ReadLine())!=null) //证明本地读取到了数据 ，就进入循环体，打印内容
            {
                Console.WriteLine(data);
            }




            //Console.WriteLine(words);
            //4.关闭读取器
            sr.Close();
            //5.关闭流
            fs.Close();
            Console.WriteLine("大爷，读取成功！！！！");

        }
        //2.写入文本文件
        private static void WriteToFile()
        {
            FileStream fs = new FileStream("E:\\晚自习.txt", FileMode.Append);
            //2.创建写入器
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            //3.真正写入
            sw.WriteLine("其实如果明天我们有课，大家还是可以九点过来的，可以明天没课，但是来自习哥们儿欢迎");
            //4.关闭写入器
            sw.Close();
            //5。关闭流
            fs.Close();
            Console.WriteLine("大爷恭喜您，写入成功");
        }
    }
}
