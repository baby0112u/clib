using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123456789;
            Console.WriteLine(ConvertToChineseMoney(n));
            Console.ReadKey();
        }
        static string ConvertToChineseMoney(int num)
        {
            //金额转大写：123==>壹佰贰拾叁元
            string [] strs = { "零","壹","贰","叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            string[] weiStr = { "元", "拾", "佰", "仟", "万", "亿", };

            long n = 1234567891234;
            string strRep="";
            string str = num.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                strRep += strs[Convert.ToInt32(str[i])];
            }
            return str;
        }
    }
}
