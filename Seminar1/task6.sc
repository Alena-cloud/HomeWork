// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли число на два без остатка)

Console.WriteLine("Введите целое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

if (num1int % 2 == 0)
{
    Console.WriteLine(num1int + "число четное ");
}
else
{
    Console.WriteLine(num1int + "число не четное ");   
}
