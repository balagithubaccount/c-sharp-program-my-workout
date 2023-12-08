using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Triangle_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 6;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }
        }
    }
}

/*
Sample Output:

1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
1 2 3 4 5 6

*/
