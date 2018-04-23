using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYYurgionas_class_project_3
{
     class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;
    
        public Student(string StudentName, Instructor teacher)
        {
            this.Name = StudentName;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        

        public void SetStudentGrade(int grade)
        {
            this.Grade = grade;
        }
        public void print()
        {
            
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine("Student Information:");
            System.Console.WriteLine("Name: " + this.Name);
            System.Console.WriteLine("Grade:" + "-" + this.Grade + "-");
            System.Console.WriteLine("------------------------------------------------------");
            this.Teacher.Print();

        }

    }
   

}



