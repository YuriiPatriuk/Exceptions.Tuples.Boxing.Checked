using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Practise
{
    class LoginException : ApplicationException
    {
        public LoginException(string message)
            :base(message) //base - Exception  
        {}
    }
}
