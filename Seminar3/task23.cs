// Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
//3->1,8,27
//5->1,8,27,64,125

Console.WriteLine("Enter the number: ");
int num1 = int.Parse(Console.ReadLine()!);
int n = num1;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i * i);
}
