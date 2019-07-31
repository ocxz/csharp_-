using System;
using System.Collections.Generic;
using System.Text;

namespace ProOperation
{
    public abstract class Operation
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public Operation(int n1, int n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }

        /// <summary>
        /// 用来存储操作符，只读
        /// </summary>
        public abstract string Type { get;}

        /// <summary>
        /// 抽象的计算方法
        /// </summary>
        /// <returns>计算的结果</returns>
        public abstract int GetResult();


    }
}
