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
            Console.WriteLine("Maximum of {0} and {1} is: {2}", Num1, Num2, Math.Max(Num1, Num2));
        }
    }
}

/*
Sample Output:

C# Math Function
Input the first number: 123
Input the second number: 231
Minimum of 123 and 231 is: 123
Maximum of 123 and 231 is: 231

Sample Output:

C# Math Function
Input the first number: 341
Input the second number: 234
Minimum of 341 and 234 is: 234
Maximum of 341 and 234 is: 341

Sample Output:

C# Math Function
Input the first number: 213
Input the second number: 412
Minimum of 213 and 412 is: 213
Maximum of 213 and 412 is: 412
*/
