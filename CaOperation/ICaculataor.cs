using System;
using System.Collections.Generic;
using System.Text;

namespace CaOperation
{
    public interface ICaculataor
    {
        string CalType { get; }
        int GetResult(int n1, int n2);
    }
}
