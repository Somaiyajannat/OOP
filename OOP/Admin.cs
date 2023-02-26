using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Admin : UserLogIn
    {
        public void UserLogin(string username, string password)
        {
            if (username == "user" && password == "user@123")
            {

                Console.WriteLine("Method Overriding function successfully called");
            }
            else
            {
                Console.WriteLine("Sorry!");
            }
        }
    }
}
