using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
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
            int a = 0, b = 1, c = 1, d;
            Console.Write("Here is the fibonacci series upto {0} terms: \n{1} {2} {3} ", noOfTerms, a, b, c);
            for(int i = 4; i <= noOfTerms; i++)
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
