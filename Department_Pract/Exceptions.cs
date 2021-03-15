using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Pract
{
    class NameException : ApplicationException
    {
        public NameException(string message)
            : base(message) //base - Exception  
        { }
    }
    class SalaryException : ApplicationException
    {
        public SalaryException(string message)
            : base(message) //base - Exception  
        { }
    }
}
