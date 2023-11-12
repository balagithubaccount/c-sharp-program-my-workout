// See https://aka.ms/new-console-template for more information
Console.Write("Input the Array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int sum = 0;
Console.WriteLine("Input the {0} values:", size);

for (int i = 0; i < size; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    sum += arr[i];
}

Console.WriteLine("Sum of the array elements are: {0}", sum);

/*  
 
 Sample Output:

Input the Array size: 5
Input the 5 values:
1
2
3
4
5
Sum of the array elements are: 15

 */


