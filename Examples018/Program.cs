// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите координаты точек b1,k1 и b2,k2 (Через Enter)");

var b1 = Convert.ToDouble(Console.ReadLine());
var k1 = Convert.ToDouble(Console.ReadLine());
var b2 = Convert.ToDouble(Console.ReadLine());
var k2 = Convert.ToDouble(Console.ReadLine());

  
var x = (b2 - b1) / (k1 - k2);
var y = k1 * (b2 - b1) / (k1 - k2) + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
