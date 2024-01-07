using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            long givNum,
                fact;

            Program instance = new Program();
            Console.Write("Input the Integer value: ");
            givNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Given Number : {0}", givNum);
            fact = instance.Factorial(givNum);
            Console.WriteLine("Factorial of {0} is: {1}.", givNum, fact);
        }

        long Factorial(long n)
        {
            long num;

            if (n > 0)
                num = n;
            else
                num = -1 * n;

            long fact = 1,
                i;
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            if (n < 0)
                return -1 * fact;
            else
                return fact;
        }
    }
}

/*
Sample Output:

Input the Integer value: 12
Given Number : 12
Factorial of 12 is: 479001600.

Sample Output:

Input the Integer value: -13
Given Number : -13
Factorial of -13 is: -6227020800.
*/
