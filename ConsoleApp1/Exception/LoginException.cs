using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception1
{
    public class LoginException : Exception
    {
        public LoginException(string msj) : base(msj)
        {

        }
    }
}
