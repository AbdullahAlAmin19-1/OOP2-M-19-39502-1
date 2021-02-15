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
            Console.Write("Array in reverse order : ");
            int[] arr1 = { 1, 2, 3, 4, 5 };
            for(int i = arr1.Length; i>0;i--)
            {
                Console.Write(arr1[i-1]+ " ");
            }
            Console.WriteLine();



            int sum=0;
            for (int j = 0; j < arr1.Length; j++)
            {
                sum=sum+arr1[j];
            }
            Console.WriteLine("Sum of the array elements is {0}.",sum);


            Console.Write("Array elements in new arrray : ");
            int[] arr2 = new int[5];
            for (int k = 0; k < arr1.Length; k++)
            {
                arr2[k] = arr1[k];
            }
            for (int l = 0; l < arr2.Length; l++)
            {
                Console.Write(arr2[l] + " ");
            }
            Console.WriteLine();

            int[] arr3 = { 1, 1, 2, 3, 4, 4, 5, 6, 6, 7};
            for(int m = 0; m < arr3.Length; m++)
            {
                for(int n = m+1; n < arr3.Length; n++)
                {
                    if(arr3[m]==arr3[n])
                        Console.WriteLine("Number {0} has a duplication.", arr3[m]);
                }
            }
            Console.WriteLine(); 

            
            for (int o = 0; o < arr3.Length; o++)
            {
                int unique=0;
                for (int p = o + 1; p < arr3.Length; p++)
                {
                    if (arr3[o] == arr3[p])
                        unique = 1;break;
                }
                if(unique==0)
                    Console.WriteLine("Number {0} is unique.", arr3[o]);
            }
        }
    }
}
