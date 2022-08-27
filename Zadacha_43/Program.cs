// Задача № 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями: y = k1 * x + b1; 
// y = k2 * x + b2, значения k1, b1, k2, b2 задаються пользователем.

using static System.Console;
Clear();

WriteLine("Введите значение k1 :");
double k1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значение b1 :");
double b1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значение k2 :");
double k2 = Convert.ToDouble(ReadLine());
WriteLine("Введите значение b2 :");
double b2 = Convert.ToDouble(ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
WriteLine($"[{String.Join(",", x, y)}]");