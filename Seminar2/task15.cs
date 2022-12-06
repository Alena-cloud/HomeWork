// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//6 -> да 
//7 -> да 
//1 -> нет

Console.WriteLine("Enter number indicating the day of the week: ");
int dayNumber = int.Parse(Console.ReadLine()!);

{
    if (dayNumber == 6 || dayNumber == 7)
   {
    Console.WriteLine("This day is weekend");
}
   else if (dayNumber < 1 || dayNumber > 7)
   {
    Console.WriteLine("This is not a day of the week");
}
else Console.WriteLine("This day is not weekend");
}
