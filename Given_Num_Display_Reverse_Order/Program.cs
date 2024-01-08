using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int givNum;
            int revNum = 0;
            int rem,
                baseNum = 1;
            GET:
            Console.Write("Input the Positive Integer value: ");
            givNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Given Number : {0}", givNum);
            if (givNum > 0)
            {
                int i = givNum;
                while (i > 0)
                {
                    rem = i % 10;
                    revNum = (revNum * baseNum) + rem;
                    baseNum = 10;
                    if (i >= 10)
                    {
                        i /= 10;
                    }
                    else
                    {
                        i = 0;
                    }
                }

                Console.WriteLine("Given Number in Reverse Order : {0}", revNum);
            }
            else
            {
                goto GET;
            }
        }
    }
}

/*
Sample Output:

Input the Positive Integer value: 7456
Given Number : 7456
Given Number in Reverse Order : 6547

Sample Output:

Input the Positive Integer value: 0
Given Number : 0
Input the Positive Integer value: -69
Given Number : -69
Input the Positive Integer value: 3412
Given Number : 3412
Given Number in Reverse Order : 2143

Sample Output:

Input the Positive Integer value: -981
Given Number : -981
Input the Positive Integer value: 981
Given Number : 981
Given Number in Reverse Order : 189

*/
