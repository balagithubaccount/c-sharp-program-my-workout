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
            if(givenNum > 0)
            Console.WriteLine("Positive.");
            else if(givenNum < 0)
            Console.WriteLine("Negative.");
            else
            Console.WriteLine("Zero.");
        }
    }
}

/*
Sample Output:

Enter the integer value: 43
Given Number 43 is Positive.

Enter the integer value: -132
Given Number -132 is Negative.

Enter the integer value: 0
Given Number 0 is Zero.
*/