// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа в данном интервале: ");
int i =  1;
int div = 1;
while (i <= num)
{
    if (div == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
    div = i % 2;

}
