using ConsoleApp1.Constans;
using ConsoleApp1.Exception1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Auth
{
    public class Account
    {

        public string userName, password;
        public void Login(string username, string password)
        {
            
            
                if (password.Length > 6)
                {
                    
                    Console.WriteLine("Login and password is success ");
                    return;

                }
                else
                {
                    throw new LoginException(Messages.LoginMessage);
                }
               

            
            

        }
    }
}
