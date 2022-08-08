// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("a = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
System.Console.WriteLine($"max = {max}");