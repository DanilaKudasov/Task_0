﻿// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Примеры:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1 -> ");
int num1 =  int.Parse(Console.ReadLine());
Console.Write("Введите число 2 -> ");
int num2 =  int.Parse(Console.ReadLine());
if (num1 > num2) Console.Write("Число 1 больше");
else Console.Write("Число 2 больше");
    
