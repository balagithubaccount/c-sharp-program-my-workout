﻿using System;
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
            int row;
            Console.Write("Input the Number of Row: ");
            row = Convert.ToInt32(Console.ReadLine());

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

Input the Number of Row: 2
1   
1 2 

Sample Output:

Input the Number of Row: 5
1         
1 2       
1 2 3     
1 2 3 4   
1 2 3 4 5 

Sample Output:

Input the Number of Row: 8      
1 
1 2 
1 2 3         
1 2 3 4       
1 2 3 4 5     
1 2 3 4 5 6   
1 2 3 4 5 6 7 
1 2 3 4 5 6 7 8

Sample Output:

Input the Number of Row: 10
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
1 2 3 4 5 6
1 2 3 4 5 6 7        
1 2 3 4 5 6 7 8      
1 2 3 4 5 6 7 8 9    
1 2 3 4 5 6 7 8 9 10 

*/
