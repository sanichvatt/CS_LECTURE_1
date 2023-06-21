// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите 3 числа: ");
Console.Write("a = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (num1 >= num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"max = {max}");

