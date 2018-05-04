using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0200HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTable  K+V
            Hashtable table = new Hashtable();
            table.Add("CBC","中国建设银行");
            table.Add("ABC", "中国农业银行");
            table.Add("ICBC", "中国工商银行");
            //遍历  双列集合的     迭代  方式只能是for增强
            //方案一： 通过key获取Value
            foreach (string key in table.Keys)
            {
                Console.WriteLine(key);
                //双列集合如何通过key获取value
                Console.WriteLine(table[key]);
            }
            Console.WriteLine("=====高贵的分割线======");
            //方案二：直接获取value ，因为value是程序中关心的数据
            foreach (string value in table.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("=====高贵的分割线======");
            //方案三：同时迭代key+value
            foreach(DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            Console.ReadLine();

        }
    }
}
