using System;
using System.Collections.Generic;

namespace _05_泛型委托
{
    public delegate int DelCompare<T>(T o1, T o2);
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、求各数组的最大值

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //string[] strs = { "afds", "affasdfsa", "afd", "aftwjt", "afauhb" };
            //Person[] persons =
            //{
            //    new Person(){Name="张三",Age=18},
            //    new Person(){Name="李四",Age=19},
            //    new Person(){Name="王五",Age=23},
            //    new Person(){Name="赵六",Age=13},
            //};
            //int maxNum = GetMax<int>(nums, (num1, num2) => { return num1 - num2; });
            //Console.WriteLine(maxNum);
            //Console.ReadKey();

            //string maxStr = GetMax<string>(strs, (str1, str2) => { return str1.Length - str2.Length; });
            //Console.WriteLine(maxStr);
            //Console.ReadKey();

            //Person maxAgePerson = GetMax<Person>(persons, (person1, person2) => { return person1.Age - person2.Age; });
            //Console.WriteLine(maxAgePerson.Name + " " + maxAgePerson.Age);
            //Console.ReadKey(); 

            #endregion

            #region 2、list 委托测试
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //list.RemoveAll(n =>  n > 3);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion
        }

        public static T GetMax<T>(T[] vars, DelCompare<T> del)
        {
            T max = vars[0];
            foreach (T item in vars)
            {
                max = del(max, item)>0 ? max : item;
            }
            return max;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
