using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Encupsulation

namespace OOP
{
    public  class LogIn
    {
        
        private string Password;
        public void SetPassWord(string pass)
        {
            this.Password= pass;
        }
        public string Getpassword()
        {
            return this.Password;
        }
        
        public void PrintPassWord()
        {
            Console.WriteLine(Getpassword());
        }
        
    }
}
