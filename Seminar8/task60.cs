// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int x = 2;
int y = 2;
int z = 2;

int[,,] array3D = new int[x, y, z];
Create3Darray(array3D);
Print3Darray(array3D);

void Print3Darray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k}) {array3D[i, j, k]}; ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] Matrix3D(int x, int y, int z)
{
    bool[] array = new bool[100];
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                if (!array[matrix[i, j, k]])
                    array[matrix[i, j, k]] = true;
                else
                    k--;
            }
        }
    }
    return matrix;
}
void Create3Darray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 99);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 99);
                    j = 0;
                    number = temp[i];
                }
                    number = temp[i];
            }
        }
    }
        int count = 0;
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    array3D[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
