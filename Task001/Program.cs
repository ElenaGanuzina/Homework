// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("a = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) 
    max = number2;
System.Console.WriteLine($"max = {max}");

