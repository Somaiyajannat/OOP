using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// inheritance

namespace OOP
{
    public  class Teacher :Student
    {
        public string TeacherId { get; set; }
        public string TeacherName { get; set; }
        
        public void TeacherInfo( string Id, string name)
        {
            TeacherId = Id;
            TeacherName = name;
            Console.WriteLine($"TeacherId :{TeacherId} TeacherName: {TeacherName}");
        }

    }
}
