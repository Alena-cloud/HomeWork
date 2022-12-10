// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Enter number: ");           // запрашивается ввод числа
int numberN = int.Parse(Console.ReadLine()!);

int digit = anotherdigit(numberN);            // объявляется переменная, в которую будет записываться сумма
Console.WriteLine(digit);

int anotherdigit(int x)
{
    int sum = 0;
    while (x >= 10)
    {
        sum += x % 10;                      // в переменной (int) сохраняем % - остаток от деления // целочисленное деление(без остатка)                      
        x /= 10;                          
    }
    return sum + x;                         //Console.WriteLine("Summa of digital currency in the number is: ", sum);   // результат
    
}
