// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 1-ое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число:");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b>a){
     max = b;
     Console.WriteLine("Максимальное число:");
     Console.Write(max);
}
else{
    if(b==a)
    Console.WriteLine("Они одинаковы");
}