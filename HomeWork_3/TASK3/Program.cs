// Задача 2
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int Prompt(string messege)
{
    Console.Write($"{messege}");
    return int.Parse(Console.ReadLine());
}

bool IfPositive(int arg1)
{
    if (arg1 > 0) return true;        
    return false;
}

int num = Prompt("Введите число -> ");
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}



