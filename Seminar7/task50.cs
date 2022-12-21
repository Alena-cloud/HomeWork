// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1
//7 -> такого числа в массиве нет

Console.WriteLine("Enter m");              // number of rows
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter n");              // number of columns
int n = int.Parse(Console.ReadLine()!);

int[,] elements = new int[m, n];
Fill2DArray(elements);

if (n > elements.GetLength(0) || m > elements.GetLength(1))
{
    Console.WriteLine("There is no this element in the array");
}
else
{
    Console.WriteLine($"Elements {n}, {m} = {elements[n - 1, m - 1]}");
}
Print2DArray(elements);

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}
