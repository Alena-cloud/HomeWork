// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3 D пространстве
//A(3,6,8); B(2,1,-7), ->15.84
//A(7,-5,0); B(1,-1,9), ->11.53

Console.WriteLine("Enter coordinate X point A");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinate Y point A");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinate Z point A");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter coordinate X point B");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinate Y point B");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinate Z point B");
double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(distance);
