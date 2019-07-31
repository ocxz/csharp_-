using System;
using System.Collections.Generic;
using System.Text;
using ProOperation;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    class Factory
    {
        public static Operation GetOper(string type, int n1, int n2)
        {
            Operation oper = null;

            // 动态获得程序集
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plug");

             

            Assembly ass = Assembly.LoadFile(path);

            return oper;
        }
    }
}
