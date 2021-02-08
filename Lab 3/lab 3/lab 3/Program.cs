using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string student_name = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            string student_id = Console.ReadLine(); 
            Console.Write("Enter Department: ");
            string department = Console.ReadLine();
            Console.WriteLine();            

            Console.Write("Enter X Axis: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y Axis: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter Z Axis: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine();            

            Console.Write("Enter Account Name: ");
            string account_name = Console.ReadLine();
            Console.Write("Enter Account ID: ");
            string account_id = Console.ReadLine();
            Console.Write("Enter Balance: ");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Deposit Ammount: ");
            int deposit = int.Parse(Console.ReadLine());
            Console.Write("Enter Withdraw Ammount: ");
            int withdraw = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Course Name: ");
            string course_name = Console.ReadLine();
            Console.Write("Enter Course ID: ");
            string course_id = Console.ReadLine();
            Console.Write("Enter Credit: ");
            int credit = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Student s = new Student(student_name, student_id, department, 3.5F);
            s.ShowInfo();

            Triangle t = new Triangle(x, y, z);
            t.TestTriangle();

            Account a = new Account(account_name, account_id, balance);
            a.Deposit(deposit);
            a.Withdraw(withdraw);

            Course c = new Course(course_name, course_id, credit);
            c.ShowCourseInfo();
        }
    }
}
