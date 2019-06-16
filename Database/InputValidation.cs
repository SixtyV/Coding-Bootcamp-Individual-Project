using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class InputValidation
    {
        public static bool UsernamePassword(string input)
        {

            if ((input.Length > 3) && (input.Length <= 16) && (!input.Contains(" ")))
                return true;

            return false;

        }
    }
}
