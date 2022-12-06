// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//645 -> 5
//78 -> третьей цифры нет 
//32679 -> 6

Console.WriteLine("Enter number: ");
string num1 = Console.ReadLine()!;

if (num1[0] == '-')
{
    if (num1.Length >= 4)
    {
        Console.WriteLine(num1[3]);
    }
    else
    {
        Console.WriteLine("The number is one or two-digit");
    }
}     
else
{
    if (num1.Length >= 3)
    {
        Console.WriteLine(num1[2]);
    }  
    else
    {
        Console.WriteLine("The number is one or two-digit");
    }
}

