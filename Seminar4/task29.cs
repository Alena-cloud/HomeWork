// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter number n: ");       
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number min: ");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number max: ");
int max = int.Parse(Console.ReadLine()!);


int[] myArray = new int[number];
FillArray(myArray);
PrintArray(myArray);

void FillArray(int[]myArray)
{
   for (int i = 0; i < myArray.Length; i++)
   {
    myArray[i] = new Random().Next(min,max+1);
   } 
}
void PrintArray(int[]myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
    Console.Write($"{myArray[i]}"); 
    }  
}

