using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,
                lastName,
                fullName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your second name: ");
            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            Console.WriteLine("First Name is: " + firstName);
            Console.WriteLine("Last Name is: " + lastName);
            Console.WriteLine("Full Name is: " + fullName);
        }
    }
}
/*
Sample Output:

Enter your first name: John
Enter your second name: Wick
First Name is: John
Last Name is: Wick
Full Name is: John Wick

Sample Output:

Enter your first name: Bala
Enter your second name: Saravanan
First Name is: Bala
Last Name is: Saravanan
Full Name is: Bala Saravanan

*/
