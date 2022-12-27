// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Enter M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine()!);

int CountElements(int m, int n)
{
    int first = m;
    int last = n;
    if (m > n)
    {
        first = n;
        last = m;
    }
    return (last + first) * (last - first + 1) / 2;  // sum of terms of arithmetic progression
}
Console.WriteLine(CountElements(1, 15));
