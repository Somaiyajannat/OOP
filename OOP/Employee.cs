using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee : Meals
    {
        public override void MealsInfo()
        {
            Console.WriteLine("Meals For All Staff is Free");
        }
    }
}
