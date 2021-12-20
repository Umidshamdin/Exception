using ConsoleApp1.Auth;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                Account account = new Account();

                string userName = "Umid Shamdinli";
                string password = "1234567";

                account.Login(userName, password);
                Console.WriteLine(account);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
          

         
        }
    }
}
