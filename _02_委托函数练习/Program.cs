using System;

namespace _02_委托函数练习
{
    public delegate string DelProStr(string str);
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  1、所有元素转化为大写
             *  2、所有元素转化为小写
             *  3、将所有元素两边加上一个双引号
             * 
             */
            #region 1、所有元素转化为大写、所有元素转化为小写、将所有元素两边加上一个双引号

            string[] names = { "abcdDE", "DFGHsafds", "FSDAeafcfaddsFDsa" };
            ProString(names, (name) => { return name.ToUpper(); });

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            ProString(names, (name) => { return name.ToLower(); });
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            ProString(names, (name) => { return "\"" + name + "\""; });
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            #endregion


        }

        public static void ProString(string[] names, DelProStr del)
        {
            int i = 0;
            foreach (var item in names)
            {
                names[i] = del(item);
                i++;
            }
        }
    }
}
