using System;
using System.Collections.Generic;
using System.Text;
using CaOperation2;
namespace CaAdd2
{
    public class Add : ICaculator
    {
        public string CalType
        {
            get
            {
                return "+";
            }

        }

        int ICaculator.GetResult(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
