using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Abdullah", 12345, 3.50f);
            Student s2 =new Student("Al Amin", 12345, 3.00f);
            Student s3 = new Student("Noman", 12345, 3.50f);
            
            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Computer Engennering", "CE");

            d1.AddStudent(s1,s2);
            d2.AddStudent(s3);

            d1.ShowDepartmentDetails();
            Console.WriteLine("**********");
            d2.ShowDepartmentDetails();
            Console.WriteLine("##########");
            s1.ShowStudentDetails();
            Console.WriteLine("**********");
            s2.ShowStudentDetails();
            Console.WriteLine("**********");
            s3.ShowStudentDetails();
        }
    }
}
