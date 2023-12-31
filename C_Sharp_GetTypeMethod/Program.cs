using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(myInt.GetType());
            Console.WriteLine(myDouble.GetType());
            Console.WriteLine(myBool.GetType());
        }
    }
}
/*
Sample Output:

System.Int32
System.Double 
System.Boolean
*/