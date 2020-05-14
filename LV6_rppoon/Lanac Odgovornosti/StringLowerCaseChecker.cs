using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV6_rppoon.Lanac_Odgovornosti
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if(stringToCheck.Any(char.IsLower))
            {
                return true;
            }
            return false;
        }
    }
}
