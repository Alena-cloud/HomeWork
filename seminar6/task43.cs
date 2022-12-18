// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter K1: ");                    // значения задаются пользователем 
var k1 = Convert.ToDouble(Console.ReadLine()!);     // значения конвертируются в десятичное число

Console.WriteLine("Enter B1: ");
var b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Enter K2: ");
var k2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Enter B2: ");
var b2 = Convert.ToDouble(Console.ReadLine()!);

var x = -(b1 - b2) / (k1 - k2);                    // находим х и у
var y = k1 * x + b1;

x = Math.Round(x, 3);                               // возвращает округленное число к ближайшему целому
y = Math.Round(y, 3);

Console.WriteLine($"Intersection of straight lines at a point: ({x}; {y})");  // выводит результат
