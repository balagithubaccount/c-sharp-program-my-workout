using System;

namespace c_sharp_math_function_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double givNum;
            Console.WriteLine("C# Math Function:");
            Console.Write("Input the value: ");
            givNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square Root of {0} is: {1}", givNum, Math.Sqrt(givNum));
            Console.WriteLine("Round of 912.3254 is: {0}", Math.Round(912.3254));
        }
    }
}

/*
Sample Output:

C# Math Function:
Input the value: 64
Square Root of 64 is: 8
Round of 912.3254 is: 912

*/
