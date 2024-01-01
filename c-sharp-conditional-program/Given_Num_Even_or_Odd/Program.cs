using System;

namespace MyApplication
{
    class Program
    {
        static Type a = typeof(double);

        // Main method
        static void Main() 
        { 
            int givenNum;
            Console.Write("Enter the integer value: ");
            givenNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Given Number {0} is ", givenNum);
            if(givenNum % 2 == 0)
            Console.WriteLine("Even.");
            else 
            Console.WriteLine("Odd");
        }
    }
}

/*
Sample Output:

Enter the integer value: 53
Given Number 53 is Odd
*/