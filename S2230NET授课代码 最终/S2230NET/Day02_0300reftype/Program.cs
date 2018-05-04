using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0300reftype
{
    class Program
    {
        static void Main(string[] args)
        {
            //小龙和小明去年身高与体重均为170cm和60kg，
            int[]  xlinfos={170,60};
            int[] xminfos = {170,60};
            Console.WriteLine("小龙去年的身高是{0},体重是{1},小明的身高是{2},体重是{3}", xlinfos[0], xlinfos[1], xminfos[0], xminfos[1]);
            //小明今年身高和体重变为180cm和70kg，小龙无变化。
            xminfos[0] = 180;
            xminfos[1] = 70;
            //输出两人的身高和体重
            Console.WriteLine("小龙今年的身高是{0},体重是{1},小明的身高是{2},体重是{3}", xlinfos[0], xlinfos[1], xminfos[0], xminfos[1]);
            Console.ReadLine();
        }
    }
}
