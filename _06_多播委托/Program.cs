using System;

namespace _06_多播委托
{
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = Test1;

            // 多播 多个指向
            del += Test2;
            del += Test3;
            del += Test4;

            del();
            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("我是Test1");
        }

        static void Test2()
        {
            Console.WriteLine("我是Test2");
        }

        static void Test3()
        {
            Console.WriteLine("我是Test3");
        }

        static void Test4()
        {
            Console.WriteLine("我是Test4");
        }
    }
}
