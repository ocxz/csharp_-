using System;

namespace _04_委托求数组的最大值
{
    public delegate int DelCompare(object obj1,object obj2);
    class Program
    {
        static void Main(string[] args)
        {
            object[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            object[] strs = { "afds", "affasdfsa", "afd", "aftwjt", "afauhb" };
            object[] persons =
            {
                new Person(){Name="张三",Age=18},
                new Person(){Name="李四",Age=19},
                new Person(){Name="王五",Age=23},
                new Person(){Name="赵六",Age=13},
            };


            int max = (int)GetMax(nums, (num1, num2) => { return (int)num1 - (int)num2; });
            Console.WriteLine(max);
            Console.ReadKey();

            string maxStr = (string)GetMax(strs, (str1, str2) => { return str1.ToString().Length - str2.ToString().Length; });
            Console.WriteLine(maxStr);
            Console.ReadKey();

            Person maxAgePerson = (Person)GetMax(persons, (person1, person2) =>
            {
                return ((Person)person1).Age - ((Person)person2).Age;
            });
            Console.WriteLine(maxAgePerson.Name + " " + maxAgePerson.Age);
            Console.ReadKey();

        }

        public static object GetMax(object[] objs, DelCompare del)
        {
            object max = objs[0];
            foreach (var item in objs)
            {
                max = del(max, item) > 0 ? max : item;   // 需要传递一个比较的方式
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
