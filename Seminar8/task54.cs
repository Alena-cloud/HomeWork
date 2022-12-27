Console.WriteLine($"Enter a size of array, how many rows?: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a size of array, how many columns?: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a min range of array: ");
int rangeMin = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a max range of array: ");
int rangeMax = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nCreated array: ");
double[,] array = CreateArray(rows, columns, rangeMin, rangeMax);
PrintArray(array);
Console.WriteLine(array);

Console.WriteLine($"\nSorted array: ");
OrderArrayLines(array);
PrintArray(array);

double[,] CreateArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void OrderArrayLines(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    double temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

