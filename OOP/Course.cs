using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }

        public void CourseDetails(string CourseId, string CourseName, int CourseCredit)
        {
            Console.WriteLine($"CourseId: {CourseId} \nCourseName : {CourseName}\nCourseCredit : {CourseCredit}");
        }
    }
}
