System.Console.Clear();
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int WriteInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = WriteInt("Введите цифру -> ");

Console.Write($"{num} -> ");

if (num > 7 || num < 1)
{
    Console.WriteLine("Данная цифра не является днем недели");
}
else
{
    if (num == 7 || num == 6)
    {
        Console.WriteLine("да, выходной");
    }
    else
    {
        Console.WriteLine("нет, будний");
    }
}