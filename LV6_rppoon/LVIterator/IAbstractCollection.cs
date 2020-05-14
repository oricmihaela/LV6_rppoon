using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.LVIterator
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
