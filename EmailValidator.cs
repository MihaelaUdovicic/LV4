using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return hasMon(candidate) && Ending(candidate);
            
        }
        
        private bool hasMon(string candidate)
        {
            if (candidate.Contains("@")) return true;
            return false;
        }
        private bool Ending(string candidate)
        {
            string endsCom = ".com";
            string endsHr = ".hr";
            if (candidate.EndsWith(endsCom) || candidate.EndsWith(endsHr)) return true;
            return false;
        }


    }
}
