// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter number A: ");              //число, которое нужно возвести в степень
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number B: ");              // степень числа
int numberB = int.Parse(Console.ReadLine()!);
int number = 1;                                     // число, возведенное в степень
for (int i = 0; i < numberB; i++)
{
    number *= numberA;
}
Console.WriteLine("{0} ^ {1} = {2}", numberA, numberB, number);
