using System;
using System.Collections.Generic;
using System.Text;

namespace CaOperation2
{
    public interface ICaculator
    {
        string CalType { get; }
        int GetResult(int n1, int n2);
    }
}
