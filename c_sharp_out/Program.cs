using System;

namespace CallByRef_C_
{
    internal class Program
    {
        static void Show(out int num)
        {
            int value = 10;
            num = value;
        }
        static void Main(string[] args)
        {
            int n = 100;

            Console.WriteLine("Before Calling: " + n);
            Show(out n);
            Console.WriteLine("After Calling: " + n);
        }
    }
}

/*
Sample Output:

Before Calling: 100
After Calling: 10

*/