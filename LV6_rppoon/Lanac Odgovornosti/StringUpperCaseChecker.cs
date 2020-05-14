using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV6_rppoon.Lanac_Odgovornosti
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if(stringToCheck.Any(char.IsUpper))
            {
                return true;
            }
            return false;
        }
    }
}
