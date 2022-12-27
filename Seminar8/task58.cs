// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] firstMatrix = CreatefirstMatrix();
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreatesecondMatrix();
PrintMatrix(secondMatrix);
Console.WriteLine();
PrintMatrix(ProductMatrix(firstMatrix, secondMatrix));

int[,] CreatefirstMatrix()
{
    int[,] matrix = new int[3, 3];
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int[,] CreatesecondMatrix()
{
    int[,] matrix = new int[2, 2];
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
int[,] ProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productMatrixFS = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < secondMatrix.GetLength(1); n++)
            {
                productMatrixFS[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
            }
        }
    }
    return productMatrixFS;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
