// See https://aka.ms/new-console-template for more information
Console.Write("Input the array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine("Enter the {0} Elements:", size);
for (int i = 0; i < size; i++)
{   
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
foreach (int i in arr)
    sum += i;

Console.WriteLine("Sum is: {0}", sum);

/*    
Sample Output:

Input the array size: 10
Enter the 10 Elements:
1
2
3
4
5
6
7
8
9
10
Sum is: 55
 
 */