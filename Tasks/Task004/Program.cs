﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Все четные числа: ");
for (int n = 2; n <= i; n += 2)
 Console.Write($"{n} ");
