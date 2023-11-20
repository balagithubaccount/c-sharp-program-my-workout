using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
       Console.Write("Input the string in lowercase: ");
       string str;
       str = Console.ReadLine();
       Console.WriteLine("Given string(in Upper): {0}", str.ToUpper());
    }
  }
}
/*
Sample Output:

Input the string in lowercase: c# program
Given string(in Upper): C# PROGRAM

*/