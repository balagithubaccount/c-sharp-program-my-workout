// See https://aka.ms/new-console-template for more information
Console.Write("Input the array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine("Enter the {0} Elements: ", size);

for (int i = 0; i < size; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
Console.WriteLine("Sorted Array is:");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

/*

Sample Output:1

Input the array size: 6
Enter the 6 Elements:
1
2
6
5
4
3
Sorted Array is:
1
2
3
4
5
6

Sample Output:2

Input the array size: 8
Enter the 8 Elements:
8
1
7
2
6
3
5
4
Sorted Array is:
1
2
3
4
5
6
7
8

*/
