using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Department
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String id;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public Department()
        {
            student = new Student[100];
        }
        public Department(String name, String id)
        {
            this.name=name;
            this.id=id;
            student = new Student[100];
        }

        private int studentcount;

        public int StudentCount
        {
            get { return studentcount; }
            set { studentcount = value; }
        }

        private Student[]  student;

	    public void AddStudent(params Student[] stu)
	    {
		    foreach(Student s in stu)
            {
                student[studentcount++]=s;
                s.Dept=this;
            }
	    }

        public void PrintStudents()
        {
            for(int i=0;i<studentcount;i++)
            {
                student[i].ShowStudentInfo();
            }
        }
        public void ShowDepartmentInfo()
        {
            Console.WriteLine("Department : " +name);
            Console.WriteLine("DepartmentID : " +id);
        }

        public void ShowDepartmentDetails()
        {
            ShowDepartmentInfo();
            PrintStudents();
        }
	
    }
}
