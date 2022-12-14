// Задайте массив вещественных чисел. Найдите разницу между мак и мин элементов массива.
//[3 7 22 2 78]->76

Console.WriteLine("Enter the size of the array: ");
int Length = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the min value of the array: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the max value of the array: ");
int max = int.Parse(Console.ReadLine()!);

int[] array = GetArray(Length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindDifference(array, max, min);

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
void FindDifference(int[] MyArray, int minVal, int maxVal)
{
    int value = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] < minVal)
        {
            minVal = MyArray[i];
        }
        if (MyArray[i] > maxVal)
        {
            maxVal = MyArray[i];
        }
    }
    Console.WriteLine($"Difference between max and min array elements is: {maxVal - minVal}");
}
