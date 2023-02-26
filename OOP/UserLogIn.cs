using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// static or compile time polymorphism
// function overloading

namespace OOP
{
    public class UserLogIn
    {
        public virtual void UserLogin(string username, string password)
        {
            if (username == "user" && password == "user@123")
            {
               
                Console.WriteLine("{0} is valid and Loged sucessfully.........", username);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }
        public void UserLogin(string username, string password, string role)
        {
            if (username == "user" && password == "user@123" && role == "employee")
            {
               
                Console.WriteLine("{0} is valid and Loged sucessfully Employee.........", username);
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password!");
            }
        }

    }
}
