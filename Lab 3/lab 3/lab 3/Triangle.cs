using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Triangle
    {
        int x; 
        int y;
        int z;

        public int X
        {
            set 
            {
                x = value; 
            }
            get 
            { 
                return x; 
            }
        }

        public int Y
        {
            set 
            { 
                y = value; 
            }
            get 
            { 
                return y; 
            }
        }

        public int Z
        {
            set 
            { 
                z = value; 
            }
            get 
            { 
                return z; 
            }
        }

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void TestTriangle() 
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }

            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }

            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
            Console.WriteLine();
        }
    }
}
