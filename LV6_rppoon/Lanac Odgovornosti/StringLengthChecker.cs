using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.Lanac_Odgovornosti
{
    class StringLengthChecker : StringChecker
    {
        public int wantedLength;
        public StringLengthChecker(int length) : base()
        {
            this.wantedLength = length;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length == wantedLength)
            {
                return true;
            }
            return false;
        }
    }
}
