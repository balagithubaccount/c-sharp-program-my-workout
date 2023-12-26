using System;

public class First
{
    public static int Main()
    {
        int a = 5;
        int b = 10;
        int result;

        result = (a > 0) ? ((b > 0) ? (a = 10) : (a = 5)) : a;

        Console.WriteLine("Result: {0}", result);

        // Return a value indicating the program executed successfully
        return 0;
    }
}
