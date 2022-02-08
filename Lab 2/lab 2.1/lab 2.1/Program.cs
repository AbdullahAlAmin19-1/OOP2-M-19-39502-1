using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Even Numbers: ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0) { Console.Write(i + "\n"); }
            }
        }
    }
}