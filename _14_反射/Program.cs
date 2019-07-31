using System;
using System.IO;
using System.Reflection;    // 反射 Assembly

namespace _14_反射
{
    class Program
    {
        static void Main(string[] args)
        {
            // 加载程序集文件
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Common.dll");
            Assembly ass = Assembly.LoadFile(path);

            #region 1、获得程序集所有公开的数据

            //Type[] types = ass.GetExportedTypes();
            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.Namespace);
            //} 

            #endregion

            #region 2、获得程序集中所有数据

            //Type[] allTypes = ass.GetTypes();
            //foreach (Type item in allTypes)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.Namespace);
            //}

            #endregion

            #region 3、获得指定程序集数据

            //Type t = ass.GetType("Common.Person");
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.Namespace); 

            #endregion

            #region 4、CreateInstance 利用反射，调用默认无参构造函数，创建对象

            //Object o = ass.CreateInstance("Common.Person");
            //Console.WriteLine(o.GetType());
            //Console.ReadKey(); 

            #endregion

            #region 5、Activator.CreateInstance 调用构造函数，创建对象

            //Object o = Activator.CreateInstance(ass.GetType("Common.Person"), "李四", 18);

            #endregion

            #region 6、获得数据源中的属性信息数组

            PropertyInfo[] pros = ass.GetType("Common.Person").GetProperties();
            foreach (PropertyInfo item in pros)
            {
                Console.WriteLine(item.Name);
            }

            #endregion

            #region 7、获取数据源中的方法信息数组

            //MethodInfo[] mds = ass.GetType("Common.Person").GetMethods();
            //foreach (MethodInfo item in mds)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region 8、Invoke 执行对象方法

            //MethodInfo md = ass.GetType("Common.Person").GetMethod("SayHello");
            //// 因为SayHello是成员方法，所有调用时，需要传入对象和参数
            //md.Invoke(Activator.CreateInstance(ass.GetType("Common.Person"), "李四", 18), null); 

            #endregion

            #region 9、Invoke 执行static类方法

            //MethodInfo md = ass.GetType("Common.Person").GetMethod("SayJing");
            //md.Invoke(null, null); 

            #endregion

            Console.WriteLine("加载程序集成功！");
            Console.ReadKey();
        }
    }
}
