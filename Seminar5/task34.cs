// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программy, которая покажет кол-во четных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Enter the size of the array: ");
int length = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the min value of the array: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the max value of the array: ");
int max = int.Parse(Console.ReadLine()!);

int[] array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindEven(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}
void FindEven(int[] MyArray)
{
    int even = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] % 2 == 0)
        {
            even = even + 1;
        }
    }
    Console.WriteLine($"Even numbers {even}");
}
