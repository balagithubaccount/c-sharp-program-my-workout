Console.Write("Input the number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < row; i++)
{
    for(int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
/*
Sample Output:

Input the number of row: 7
*      
**     
***    
****   
*****  
****** 
*******
*/