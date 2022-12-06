// Задача 4. Запишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

Console.WriteLine("Введите третье число ");
string num3 = Console.ReadLine()!;
int num3int = int.Parse(num3);

if (num1int > num2int)
{
    if (num1int > num3int)
    {
        Console.WriteLine(num1int + "самое большое число");
    }
    else
    {
        Console.WriteLine(num3int + "самое большое число");
    }
}
else
{
    if (num2int > num3int)
    {
        Console.WriteLine(num2int + "самое большое число");
    }
    else
    {
        Console.WriteLine(num3int + "самое большое число");
    }
}
