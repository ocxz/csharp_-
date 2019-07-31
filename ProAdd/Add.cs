using System;
using System.Collections.Generic;
using System.Text;
using ProOperation;

namespace ProAdd
{
    public class Add : Operation
    {
        public Add(int n1, int n2) : base(n1, n2) { }

        public override string Type { get; }

        public override int GetResult()
        {
            return this.NumberOne + this.NumberTwo;
        }
    }
}
