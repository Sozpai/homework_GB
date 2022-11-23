//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine()); 

int max = a;
if(c>max) max = c;
if(b>a){
     max = b;
     Console.WriteLine("Максимальное число:");
     Console.Write(max);
}
else{
    if(b==a)
    Console.WriteLine("Первое и второе число одинаковы!");
}
if(c>b){
     max = c;
     Console.WriteLine("Максимальное число: ");
     Console.Write(max);
}
else{
    if(c==b)
    Console.WriteLine("Второе число и третье одинаковы!");
}
if(c==a){
    Console.WriteLine(" Первое число и третье одинаковы!");
}
if(a==max){
Console.WriteLine("Максимальное число: ");
     Console.Write(max);
}