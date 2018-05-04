using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0400MD5
{
    class Program
    {
        static void Main(string[] args)
        {
           string md5Value= GetMd5("1");
           Console.WriteLine(md5Value);
        }
        static string GetMd5(string msg)
        {
            string cryptStr = "";//加密后的字符串
            //MD5算法的服务提供者  里氏替换原则
            MD5 md5 = new MD5CryptoServiceProvider();
            //msg  ------>byte[]
            byte[] buffer = Encoding.Default.GetBytes(msg);
            byte[] newByte=md5.ComputeHash(buffer);
            //newByte--------->string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newByte.Length; i++)
            {
               sb.Append(newByte[i].ToString("x2"));
            }
            cryptStr = sb.ToString();
            return cryptStr;
        }
    }
}
