using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            char Grade;

            Console.Write("Enter Physics number: ");
            int phy = int.Parse(Console.ReadLine());

            Console.Write("Enter Chemistry number: ");
            int che = int.Parse(Console.ReadLine());

            Console.Write("Enter Biology number: ");
            int bio = int.Parse(Console.ReadLine());

            Console.Write("Enter Mathematics number: ");
            int math = int.Parse(Console.ReadLine());

            Console.Write("Enter Computer number: ");
            int com = int.Parse(Console.ReadLine());

            int Total = phy + che + bio + math + com;
            int Percentage = (100 * Total) / 500;

            if (Percentage >= 90)
            {
                Console.WriteLine("The Student gets Grade A+");
            }
            else if (Percentage >= 85 && Percentage < 90)
            {
                Console.WriteLine("The Student gets Grade A");
            }
            else if (Percentage >= 80 && Percentage < 85)
            {
                Console.WriteLine("The Student gets Grade B+");
            }
            else if (Percentage >= 75 && Percentage < 80)
            {
                Console.WriteLine("The Student gets Grade B");
            }
            else if (Percentage >= 50 && Percentage < 75)
            {
                Console.WriteLine("The Student gets Grade C+");
            }
            else
            {
                Console.WriteLine("The Student gets Grade F");
            }
        }
    }
    
}
