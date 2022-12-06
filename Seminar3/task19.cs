// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> no
//23432-> yes
//12821-> yes

Console.WriteLine("Enter five-digit number: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));

int[]array = new int[5];

for(int i = 0; i<=4; i++)
{
array[i]=n%10;
n=n/10;
}
if(array[0]==array[4]&&array[1]==array[3])
{
    Console.WriteLine("Yes, this number is a polindrome");
}
else
{
   Console.WriteLine("No, this number is not a polindrome"); 
}
