using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationTestAndRegex
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_FIRSTNAME,
            INVALID_FIRSTNAME,
            //EMPTY_LASTNAME,
            INVALID_LASTNAME,
            //EMPTY_EMAIL_ID,
            INVALID_EmailId,
            //EMPTY_PASSWORD,
            INVALID_PASSWORD,
            //EMPTY_MOBILE_NO,
            INVALID_MOBILE_NO
        }
        private readonly ExceptionType type;//declaration to the same class or for the construvtor we cannot acess outside the ckasss

        public UserRegistrationException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
