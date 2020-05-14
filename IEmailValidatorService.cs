using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
