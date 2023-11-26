// See https://aka.ms/new-console-template for more information
Console.WriteLine("2D Array:\n");
int[,] arr_2d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write(arr_2d[i, j] + " ");
    Console.WriteLine("\n");
}
/*
Sample Output:

2D Array:

1 2 3 

4 5 6

*/