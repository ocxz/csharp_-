using System;

namespace _15_程序集3个常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、类型.IsAssignable(类型)   判断前类型是否是后类型的父类型

            //bool b = typeof(I1).IsAssignableFrom(typeof(Student));
            //Console.WriteLine(b);
            //Console.ReadKey();

            #endregion

            #region 2、类型.IsSubclassOf(类型） 判断前类型是否是后类型的子类

            //bool b = typeof(Student).IsSubclassOf(typeof(Person));
            //Console.WriteLine(b);
            //Console.ReadKey();

            #endregion

            #region 3、类型.IsInstanceOfType(对象)  判断对象是否是该类型的实例

            //Student student = new Student();
            //bool b = typeof(Person).IsInstanceOfType(student);
            //Console.WriteLine(b);
            //Console.ReadKey(); 

            #endregion

            #region 4、类型.IsAbstract 判断类是否为抽象类

            //Console.WriteLine(typeof(Teacher).IsAbstract);
            //Console.ReadKey(); 
             
            #endregion


        }
    }

    class Person
    {

    }
    class Student : Person, I1
    {

    }

    interface I1
    {

    }

    abstract class Teacher
    {

    }

}
