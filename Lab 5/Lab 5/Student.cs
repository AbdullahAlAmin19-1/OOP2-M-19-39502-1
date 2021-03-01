using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Student
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float CGPA
        {
            get { return cgpa; }
            set { cgpa= value; }
        }

        private Department dept;

	    public  Department Dept
	    {
		    get { return dept;}
		    set { dept = value;}
	    }
	
        public Student(){}
        public Student(String name, int id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("Name : " +name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("CGPA : " + cgpa);
        }
        public void ShowStudentDetails()
        {
            ShowStudentInfo();
            dept.ShowDepartmentInfo();
        }
    }
}
