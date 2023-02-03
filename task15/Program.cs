// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!)!;

if (num <= 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Нет.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Да.");
}