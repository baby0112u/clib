namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            #region 生成一个数组 计算数组的和
            //Console.WriteLine("请输入一个正整数！");
            //string n = Console.ReadLine();
            //int[] nums = GenerateArray(n);
            //if (nums==null)
            //{
            //    Console.WriteLine("输入数字非法！");
            //    return;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //int j = AddArray(nums);
            //Console.WriteLine(j);
            //Console.ReadKey();
            #endregion

            #region 比较两个数组是否完全一样
            //int[] nums1 = { 1, 2, 3, 4, 5 };
            //int[] nums2 = { 1, 2, 3, 4, 5 };
            //int[] nums3 = { 1, 3, 2, 4, 5 };
            //bool b = IsEquals(nums1, nums2);
            //bool f = IsEquals(nums2, nums3);
            //Console.WriteLine("b=" + b + ",f=" + f);
            //Console.ReadKey();
            #endregion

            #region 计算三个数的最大值
            //int a = 5, b = 6, c = 8;
            //Console.WriteLine( GetMax(a, b, c));
            //Console.ReadKey();
            #endregion

            #region 计算用户输入的年月日是一年中的第几天
            //Console.Write("请输入年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入月份：");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("请输入日期：");
            //int date = Convert.ToInt32(Console.ReadLine());

            //int days = GetDays(year, month, date);
            //Console.WriteLine(days);
            //Console.ReadKey();
            #endregion

            #region 反转数组
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int[] newNums = MyReverse(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(newNums[i]);
            //}
            //Console.ReadKey();
            #endregion

            #region concact数组
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int[] newNums = MyReverse(nums);
            //string[] str = Concact(newNums, nums);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //Console.ReadKey();
            #endregion

            #region join数组
            string [] nums = { "rupeng","qq","sohu","baidu" };
            Console.WriteLine(MyJoin(nums));
            Console.ReadKey();
            #endregion
        }

        static string MyJoin(string[] strs)
        {
            string str="";
            for (int i = 0; i < strs.Length-1; i++)
            {
                str += strs[i]+"|";
            }
            str += strs[strs.Length - 1];
            return str;
        }

        /// <summary>
        /// concact数组
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        static string[]Concact(int[]nums1,int[]nums2)
        {
            string[] strs = new string[nums1.Length + nums2.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                strs[i] = nums1[i].ToString();
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                strs[nums1.Length + j] = nums2[j].ToString();
            }
            return strs;
        }

        /// <summary>
        /// 反转数组
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] MyReverse(int[]nums)
        {
            int[] newNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                newNums[i] = nums[nums.Length - 1 - i];
            }
            return newNums;
        }

        /// <summary>
        /// 计算用户输入的年月日是一年中的第几天
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        static int GetDays(int year,int month ,int day)
        {
            bool isRunNian=false;int days=0;
            if(year%4==0||(year%100==0&&year%4!=0))
            {
                isRunNian = true;
            }
            switch(month)
            {
                case 1:
                    days = day;break;
                case 2:
                    days = 31 + day;break;
                case 3:
                    days = 31 + 28 + day;break;
                case 4:
                    days =31*2+28+ day; break;
                case 5:
                    days = 31*2+30*1+28 + day; break;
                case 6:
                    days = 31 * 3 + 30 * 1 + 28 + day; break;
                case 7:
                    days = 31 * 3 + 30 * 2 + 28 + day; break;
                case 8:
                    days = 31 * 4 + 30 * 2+ 28 + day; break;
                case 9:
                    days = 31 * 5 + 30 * 2 + 28 + day; break;
                case 10:
                    days = 31 * 5 + 30 * 3 + 28 + day; break;
                case 11:
                    days = 31 * 6 + 30 * 3 + 28 + day; break;
                case 12:
                    days = 31 * 6 + 30 * 4 + 28 + day; break;
            }
            return days+((isRunNian&&month>2)?1:0);
        }

        /// <summary>
        /// 计算三个数的最大值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int GetMax(int a, int b, int c)
        {
            int j;
            return (j = a >= b ? a : b) > c ? j : c;
        }

        /// <summary>
        /// 比较两个数组是否完全一样
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        static bool IsEquals(int[] nums1,int[]nums2)
        {
            bool b = false;
            if(nums1.Length==nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if(nums1[i]!=nums2[i])
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }
            }
            return b;     
        }

        /// <summary>
        /// 返回输入整数的数组
        /// </summary>
        /// <param name="n">用户输入的字符串</param>
        /// <returns></returns>
        static int[] GenerateArray(string n)
        {
            int i; 
            if(int.TryParse(n,out i))
            {
                int[] nums = new int[i];
                for (int j = 0; j < i; j++)
                {
                    nums[j] = j+1;
                }
                return nums;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// 计算数组的和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int AddArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }

}
