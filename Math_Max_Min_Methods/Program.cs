using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1,
                Num2;
            Console.WriteLine("C# Math Function");

            Console.Write("Input the first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minimum of {0} and {1} is: {2}", Num1, Num2, Math.Min(Num1, Num2));
            //Console.WriteLine("Maximum of {0} and {1} is: {2}", Num1, Num2, Math.Max(Num1, Num2));
        }
    }
}

/*
Sample Output:

C# Math Function
Input the first number: 87
Input the second number: 64
Minimum of 87 and 64 is: 64

*/
