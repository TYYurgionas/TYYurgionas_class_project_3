using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYYurgionas_class_project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new Instructor("John", "English");
            var Mike = new Instructor("Mike", "Math");
            var Jane = new Student("Jane", John);
            var Joe = new Student("Joe", John);
            var Melissa = new Student("Melissa", Mike);
            var Matt = new Student("Matt", Mike);

            John.SetStudentGrades(Jane, 95);
            John.SetStudentGrades(Joe, 85);
            Mike.SetStudentGrades(Melissa, 90);
            Mike.SetStudentGrades(Matt, 92);


            System.Console.WriteLine("------------------------------------------------------");
            Jane.print();
            Joe.print();
            Matt.print();
            Melissa.print();
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();



        }
    }
}
