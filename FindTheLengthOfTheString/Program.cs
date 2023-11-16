using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLengthOfTheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string: ");
            string Str = Console.ReadLine();
            Console.WriteLine("Given String is: {0}", Str);
            Console.WriteLine("Length of the string is: {0}", Str.Length);
        }
    }
}

/* 
 Sample Output:

Input the string:
A string in C# is actually an object.
Given String is: A string in C# is actually an object.
Length of the string is: 37

 */