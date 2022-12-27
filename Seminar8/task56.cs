//Задача 56. Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine($"Enter a size of array, how many rows?: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a size of array, how many columns?: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a min range of array: ");
int rangeMin = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Enter a max range of array: ");
int rangeMax = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nCreated array: ");
double[,] array = Create2Darray(rows, columns, rangeMin, rangeMax);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"\nThe smallest sum of elements in a row: ");
Console.WriteLine(SumElementsLine(array));

double[,] Create2Darray(int m, int n, int min, int max)
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
double SumElementsLine(double[,] array)
{
    double[] sumElements = new double[array.GetLength(0)];
    double smallestSumElements = double.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements[i] += array[i, j];
            if (i == 0)
                smallestSumElements = sumElements[i];
        }
        if (sumElements[i] < smallestSumElements)
            smallestSumElements = sumElements[i];
    }
    return smallestSumElements;
}
 
