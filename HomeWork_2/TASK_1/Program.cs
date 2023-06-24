System.Console.Clear();
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int WriteInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = WriteInt("Введите трёхзначное число -> ");

if (num < 99 || num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int b = num % 100 / 10;
    Console.WriteLine($"{num} -> {b}");
}