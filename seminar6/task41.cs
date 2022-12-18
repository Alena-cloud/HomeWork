// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("How many numbers do you enter? ");
int length = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the numbers separated by a space: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"The user entered: {count} number/s greater than zero");
