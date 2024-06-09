using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number of rows: ");
        int no_of_row = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < no_of_row; i++)
        {
            for (int j = 0; j < no_of_row; j++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
    }
}

/*
Sample Output:1

Input the number of rows: 5
* * * * *
* * * * *
* * * * *
* * * * *
* * * * *

Sample Output:2

Input the number of rows: 3
* * *
* * *
* * *

*/
