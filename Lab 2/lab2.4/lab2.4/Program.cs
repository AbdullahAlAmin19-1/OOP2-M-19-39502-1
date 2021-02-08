using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Sum_Of_Even=0, Sum_Of_Odd=0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Sum_Of_Even = Sum_Of_Even + i;
                }

                else if (i % 2 != 0)
                {
                    Sum_Of_Odd = Sum_Of_Odd + i;
                }
            }
                Console.Write("The Sum of Even Numbers: ");
                Console.WriteLine(Sum_Of_Even);
                Console.Write("The Sum of Odd Numbers: ");
                Console.WriteLine(Sum_Of_Odd);
            
        }
    }
}
