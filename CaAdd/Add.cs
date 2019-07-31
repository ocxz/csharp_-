using System;
using System.Collections.Generic;
using System.Text;
using CaOperation;
namespace CaAdd
{
    public class Add : ICaculataor
    {
        public string CalType
        {
            get
            {
                return "+";
            }

        }

        int ICaculataor.GetResult(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
