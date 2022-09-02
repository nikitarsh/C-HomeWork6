﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, з
// аданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Введите точку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double length1 = (k1 * x + b1);
double length2 = (k2 * x + b2);

Console.WriteLine($"Точка пересечения двух прямых: ({length1}; {length2})");