using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// inheritance

namespace OOP
{
    public class Student : Course
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int ContactNumber { get; set; }

        public void StudentInfo(string StudentId, string StudetName, int ContactNumber)
        {
            Console.WriteLine($"StudentId: {StudentId} \nCourseName : {StudetName}\nContactNumber : {ContactNumber}");
        }
    }
       
   
}
