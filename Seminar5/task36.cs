// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях. 
// [3, 7, 23, 12]->19
// [-4, -6, 89, 6]->0

Random rnd = new Random();
Console.WriteLine("One-dimensional array filled with random numbers: \n"); // skipping a line (for aesthetics)

int[] length = new int[rnd.Next(5, 26)]; // int[] length = new int[number];
int[] result = FillArray(length, rnd.Next(5, 26), rnd.Next(26, 50));
int counts = OddSum(result);

PrintArray(result);
Console.WriteLine("\nThe sum of the elements standing in odd positions is:  " + counts);

int[] FillArray(int[] field, int minValue, int maxValue)
{
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = rnd.Next(minValue, maxValue + 1);
    }
    return field;
}
int OddSum(int[] MyArray)
{
    int sum = 0;
    for (int i = 0; i < MyArray.Length; i += 2)
    {
        sum += MyArray[i];
    }
    return sum;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write($"{array[i]} ");
    }
}
