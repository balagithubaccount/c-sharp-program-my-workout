using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string fullName = firstName + lastName;
      Console.WriteLine("First Name: " + firstName);
      Console.WriteLine("Last Name: " + lastName);
      Console.WriteLine("Full Name: " + fullName);
    }
  }
}
/*
Sample Output:

First Name: John 
Last Name: Doe     
Full Name: John Doe
*/