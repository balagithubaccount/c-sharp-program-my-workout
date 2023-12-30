using System;

namespace MyApplication
{
    class Program
    {
        static Type a = typeof(double);

        // Main method
        static void Main()
        {
            // Display the type of a
            Console.WriteLine(a);

            // Display the value type
            Console.WriteLine(typeof(int));

            // Display the class type
            Console.WriteLine(typeof(Array));

            // Display the value type
            Console.WriteLine(typeof(char));

            // Display the array reference type
            Console.WriteLine(typeof(int[]));

            // Display the string reference type
            Console.WriteLine(typeof(string));
        }
    }
}

/*
Sample Output:

System.Double
System.Int32
System.Array
System.Char
System.Int32[]
System.String

*/
