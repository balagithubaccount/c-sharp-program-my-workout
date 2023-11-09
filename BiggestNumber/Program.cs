// To find the largest of three numbers. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int bigNum = 0;

            Console.WriteLine("Input the three integer values: ");

            for(int i = 0; i < 3; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 3; i++)
            {
                if(bigNum < array[i])
                {
                    bigNum = array[i];
                }
            }
            Console.WriteLine("Largest of three numbers: " + bigNum);
        }
    }
}


/*
 Sample Output:

Input the three integer values:
45
12
-90
Largest of three numbers: 45

 */