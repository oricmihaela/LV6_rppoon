using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.LVIterator
{
    interface IBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
