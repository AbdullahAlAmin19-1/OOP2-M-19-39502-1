using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Student
    {
        string name; //Member fileds as by default private
        string id;
        string department;
        float cgpa;

        //Propertise

      public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public Student() //empty constructor
        {
            Console.WriteLine("Constructor with empty parameter...");
        }

        public Student(string name, string id, string department, float cgpa) //constructor with 3 parameter
        {
            Console.WriteLine("Constructor with 3 parameter...");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo() //ShowInfo Method
        {
            Console.WriteLine("Name is: "+name);
            Console.WriteLine("Id is: "+id);
            Console.WriteLine("Deparment is: "+department);
            Console.WriteLine("Cgpa is: "+cgpa);
        }

}
