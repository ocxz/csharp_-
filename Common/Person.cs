using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    public class Person
    {
        public static void SayJing()
        {
            Console.WriteLine("我是静态公开方法");
        }

        private static void SayPJint()
        {
            Console.WriteLine("我是静态非公开方法，怎么说");
        }


        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("我是Person类中的函数");
        }

        private void SayHi()
        {
            Console.WriteLine("我是私有的哦，你能不能调到我呢");
        }


        public void Write()
        {
            File.WriteAllText("1.txt", "张三李四王五赵六田七");
        }
    }

    public class Student
    {

    }

    class Teacher
    {

    }
}
