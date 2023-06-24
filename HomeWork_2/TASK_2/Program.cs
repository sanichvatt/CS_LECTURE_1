System.Console.Clear();
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int WriteInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = WriteInt("Введите число -> ");
if (num < 99)
{
    Console.WriteLine("В заданном числе нет третьей цифры");
}
else
{
    int b = num % 1000 / 100;
    Console.WriteLine($"{num} -> {b}");
}