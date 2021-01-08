using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {4, 7, 2, 6,9, 5};
            
            int[] ret = Filter(array1, 4);
            Console.Write("{ ");
            for (int i = 0; i < ret.Length; i++)
            {
                
                Console.Write(ret[i]+",");
               
            }
            Console.Write(" }");
            Console.ReadKey();
        }
        static int[] Filter(int[] arr1, int a)
        {
            int[] newArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] != a)
                {
                    newArray[i] = arr1[i];
                }
                
            }
            return newArray;
        }
    }
}
