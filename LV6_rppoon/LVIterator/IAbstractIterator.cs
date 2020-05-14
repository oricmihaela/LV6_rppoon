using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.LVIterator
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
