using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Validator : IRegistrationValidator
    {

        public bool IsUserEntryValid(UserEntry user)
        {
            EmailValidator email = new EmailValidator();
            PasswordValidator password = new PasswordValidator(8);
            bool validMail = false;bool validPass = false;
            if (email.IsValidAddress(user.Email)) validMail = true;
            if (password.IsValidPassword(user.Password)) validPass = true;



            return (validMail&&validPass);
        }
    }
}
