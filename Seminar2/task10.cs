//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

Console.WriteLine("Enter three-digit number: ");
int num1 = int.Parse(Console.ReadLine()!);

if ((num1 >= 100) && (num1 < 1000))
{
    int firstDigit = num1 % 100;
    int secondDigit = firstDigit / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Non-three-digit number has been entered");
}
