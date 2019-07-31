using System;
using System.Collections.Generic;

namespace _01_为什么会有委托
{
    // 声明定义委托
    public delegate void DelSayHi(string name);
    class Program
    {

        static void Main(string[] args)
        {
            /**
             *   定义：将函数作为参数传入
             * 
             */

            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //list.RemoveAll(num => num > 2);

            //SayHi("张三", SayHiChinese);
            //SayHi("张三", new DelSayHi(SayHiEnglish));
            //SayHi("张三", delegate (string name) { Console.WriteLine("O ha Yo" + name); });
            SayHi("张三", (name) => { Console.WriteLine("O Ha Yo"+name); }) ;
            Console.ReadKey();
        }


        static void SayHi(string name, DelSayHi del)
        {
            del(name);
        }

        static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了么？" + name);
        }

        static void SayHiEnglish(string name)
        {
            Console.WriteLine("Ohayo" + name);
        }
    }
}
