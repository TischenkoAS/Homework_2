// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;
int a = num / 100;
int b = num % 10;
int result = (num - a * 100 - b) / 10;
Console.WriteLine($"Вторая цифра вашего числа - {result}.");