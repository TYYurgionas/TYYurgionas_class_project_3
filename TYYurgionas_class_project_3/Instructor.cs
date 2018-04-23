using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYYurgionas_class_project_3
{
     class Instructor
    {
        private string LastName;
        private string CourseName;
      

              public Instructor(string TheTeachersName, string TheCourseName)
        {
            this.LastName = TheTeachersName;
            this.CourseName = TheCourseName;
        }



        public void SetStudentGrades(Student student, int grade)
        {
            student.SetStudentGrade(grade);
        }
        public void Print()
        {
            System.Console.WriteLine("Instructor Information: " + LastName + "-------- Course:" + CourseName);
           
          
        }
    }
}

