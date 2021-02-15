using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array in reverse order
            Console.Write("Array in reverse order : ");
            int[] arr1 = { 1, 1, 2, 3, 4, 4, 5, 6, 6, 7 };
            for(int i = arr1.Length; i>0;i--)
            {
                Console.Write(arr1[i-1]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Sum of the array elements
            int sum=0;
            for (int j = 0; j < arr1.Length; j++)
            {
                sum=sum+arr1[j];
            }
            Console.WriteLine("Sum of the array elements is {0}.", sum);
            Console.WriteLine();


            //Array elements into a new arrray
            Console.Write("Array elements into a new arrray : ");
            int[] arr2 = new int[10];
            for (int k = 0; k < arr1.Length; k++)
            {
                arr2[k] = arr1[k];
            }
            for (int l = 0; l < arr2.Length; l++)
            {
                Console.Write(arr2[l] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(); 


            //Duplicate elements in array
            int[] dup = new int[10];
            for(int m = 0; m < arr1.Length; m++)
            {
                for(int n = m+1; n < arr1.Length; n++)
                {
                    if(arr1[m]==arr1[n])
                    {
                        Console.WriteLine("Number {0} has a duplication.", arr1[m]);
                        dup[n] = arr1[m];
                    }
                }
            }
            Console.WriteLine();


            //Uniquet elements in array
            for (int o = 0; o < arr1.Length; o++)
            {
                int unique=0;
                for (int p = 0; p < dup.Length; p++)
                {
                    if (arr1[o] == dup[p])
                        unique = 1;
                }
                if(unique==0)
                    Console.WriteLine("Number {0} is unique.", arr1[o]);
            }
        }
    }
}
