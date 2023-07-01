// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int Prompt(string messege)
{
    Console.Write($"{messege}");
    return int.Parse(Console.ReadLine());
}

bool If5num(int arg1)
{
    if (arg1 > 9999 && arg1 < 100000) return true;        
    return false;
}

int num = Prompt("Введите пятизначное число: ");
int a1 = num / 10000 % 10;
int a2 = num / 1000 % 10;
int a3 = num / 10 % 10;
int a4 = num / 1 % 10;

if (If5num(num)) 
{
    if (a1 == a4 && a2 == a3)
    {
        Console.WriteLine($"{num} -> ДА");
    }
    else Console.WriteLine($"{num} -> НЕТ");
}
else Console.WriteLine("Число не пятизначное");

