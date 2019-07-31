using System;

namespace _07_泛型学习
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi<string, int>("张三", 18);
            Console.ReadKey();
        }

        public static K SayHi<T,K>(T name, K age)
        {
            Console.WriteLine(name.ToString()+age.ToString());
            return age;
        }
    }
}
