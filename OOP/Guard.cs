using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     public class Guard :Meals
     {
        public int guradId;
        public string guardName;

        public void GuardInfo()
        {
            Console.WriteLine($"guradId{guradId}\nguardName{guardName}");
        }
        public override void MealsInfo()
        {
            Console.WriteLine("All Meals For guard is 90% free");
        }
     }
}
