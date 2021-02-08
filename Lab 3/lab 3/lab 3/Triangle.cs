using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Triangle
    {
        int x; //Member fileds as by default private
        int y;
        int z;

        //properties
        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public Triangle(int x, int y, int z)
        {

            Console.WriteLine("Constructor with 3 parameter");
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void TestTriangle() //method
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The triangle is equilateral");
            }

            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("The triangle is isosceles");
            }

            else
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }
}
