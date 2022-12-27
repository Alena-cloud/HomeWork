// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine()!);

int CalculateFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m != 0)
    {
        return CalculateFunction(m - 1, 1);
    }
    else
    {
        return CalculateFunction(m - 1, CalculateFunction(m, n - 1));
    }
}
Console.WriteLine(CalculateFunction(3, 2));

