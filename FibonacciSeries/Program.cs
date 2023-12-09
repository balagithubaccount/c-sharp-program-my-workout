using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
			
            int terms = Convert.ToInt32(Console.ReadLine());
			
            Fibonacci myMethod = new Fibonacci(terms);
        }
    }
}

/*

Sample Output:
 
Input the number of terms: 10
Here is the fibonacci series upto 10 terms:
0 1 1 2 4 7 13 24 44 81

*/