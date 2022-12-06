// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

if(num1int > num2int)
{
Console.WriteLine(num1int + "Больше" + num2int);
}

else if (num2int > num1int)
{
    Console.WriteLine(num2int + "Больше" + num1int);
}

else
{
    Console.WriteLine("Числа равны");
}
