﻿// Напишите программу, которая принимает на вход координаты двух точек  
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координату Х1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double length = Math.Sqrt((X1 - X2)*(X1 - X2) + (Y1 - Y2)*(Y1 - Y2) + (Z1 - Z2)*(Z1 - Z2));
Console.WriteLine(length);

