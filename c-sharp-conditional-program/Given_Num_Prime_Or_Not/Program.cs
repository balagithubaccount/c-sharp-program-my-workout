using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum,
                count = 0;
            input:
            Console.Write("Enter the positive integer value: ");
            givenNum = Convert.ToInt32(Console.ReadLine());
            if (givenNum > 0)
            {
                for (int i = 1; i <= givenNum; i++)
                {
                    if (givenNum % i == 0)
                    {
                        count++;
                    }
                    if (count > 2)
                        break;
                }
                if (count == 2)
                    Console.WriteLine("Given number {0} is Prime.", givenNum);
                else
                    Console.WriteLine("Given number {0} is Not a Prime.", givenNum);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                goto input;
            }
        }
    }
}

/*
Sample Output 1:

Enter the positive integer value: -1
Invalid Input
Enter the positive integer value: 0
Invalid Input
Enter the positive integer value: 12
Given number 12 is Not a Prime.

Sample Output 2:

Enter the positive integer value: 0
Invalid Input
Enter the positive integer value: 23
Given number 23 is Prime.

*/
