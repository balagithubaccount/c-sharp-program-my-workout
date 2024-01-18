using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
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

    internal class Fibonacci
    {
        int noOfTerms;

        public Fibonacci(int terms)
        {
            noOfTerms = terms;
            Run();
        }

        public void Run()
        {
            int a = 0,
                b = 1,
                c = 1,
                d;
            Console.Write(
                "Here is the fibonacci series upto {0} terms: \n{1} {2} {3} ",
                noOfTerms,
                a,
                b,
                c
            );
            for (int i = 4; i <= noOfTerms; i++)
            {
                d = a + b + c;
                Console.Write("{0} ", d);
                a = b;
                b = c;
                c = d;
            }
            Console.WriteLine("\n");
        }
    }
}

/*

Sample Output:
 
Input the number of terms: 11 
Here is the fibonacci series upto 11 terms: 
0 1 1 2 4 7 13 24 44 81 149 

Sample Output:

Input the number of terms: 5
Here is the fibonacci series upto 5 terms:
0 1 1 2 4

Sample Output:

Input the number of terms: 9 
Here is the fibonacci series upto 9 terms: 
0 1 1 2 4 7 13 24 44 
*/
