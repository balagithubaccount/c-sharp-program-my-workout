// See https://aka.ms/new-console-template for more information
Console.WriteLine("Three Dimention array:");
int[,,] arr_3d = new int[2,2,2] {{{1,2},{3,4}},{{5,6},{7,8}}};

for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        for(int k = 0; k < 2; k++)
        {
            Console.WriteLine("arr_3d[{0},{1},{2}]: {3}", i, j, k, arr_3d[i,j,k]);
        }
    }
}

/*
Output:

Three Dimention array:
arr_3d[0,0,0]: 1
arr_3d[0,0,1]: 2
arr_3d[0,1,0]: 3
arr_3d[0,1,1]: 4
arr_3d[1,0,0]: 5
arr_3d[1,0,1]: 6
arr_3d[1,1,0]: 7
arr_3d[1,1,1]: 8

*/