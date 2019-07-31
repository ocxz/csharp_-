using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using CaOperation2;

namespace CaFactory
{
    class Factory
    {

        /// <summary>
        /// 根据type类型，返回相应的运算器
        /// 调用环境：有若干个dll文件，根据dll文件，拿到相应的运算器
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICaculator GetCaculataor(string type)
        {
            // 获得调用者，存放运算器dll程序集的目录
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plug");

            // 获得所有的dll程序集文件
            string[] allDllFile = Directory.GetFiles(path, "*.dll");

            // 循环遍历所有文件，加载程序集文件，获取程序集对象
            foreach (var file in allDllFile)
            {
                Assembly ass = Assembly.LoadFile(file);
                // 循环遍历程序集中所有的类型，取出符合条件的类型，返回
                foreach (Type t in ass.GetExportedTypes())
                {
                    // 如果 t是ICaculataor的子类，且不是抽象类，且类型为所选类型，则取出，构造返回运算器
                    if (typeof(ICaculator).IsAssignableFrom(t) && !t.IsAbstract)
                    {
                        ICaculator cacu = (ICaculator)ass.CreateInstance(t.FullName);
                        if (cacu.CalType == type)
                        {
                            return cacu;
                        }
                    }
                }
            }
            return null;
        }

    }
}
