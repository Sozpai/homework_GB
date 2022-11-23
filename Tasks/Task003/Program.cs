//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = n%2;
if (i==0)
Console.Write("Четное");
 else
 Console.Write("Нечетное ");

