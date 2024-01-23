Console.Write("Input the number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < row; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}

/*
Sample Output:1

Input the number of row: 7
*
**
***
****
*****
******
*******


Sample Output:2

Input the number of row: 4
*
**
***
****


Sample Output:3

Input the number of row: 10
*
**
***
****
*****
******
*******
********
*********
**********

Sample Output:4

Input the number of row: 8
*
**      
***     
****    
*****   
******  
******* 
********
*/
