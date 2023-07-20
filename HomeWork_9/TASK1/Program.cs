// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    int arg = Convert.ToInt32(inputedString);
    return arg;
}
void PrintArray(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"{matr[i]}, ");
    }
}

int i = 0;
int[] EvenNumbers(int[] array, int arg1, int arg2)
{
    if (arg1 > arg2) return array;
    array[i] = arg1;
    i++;
    return EvenNumbers(array, arg1 + 2, arg2);
}

int num1 = ReadInt("Введите значение M -> ");
int num2 = ReadInt("Введите значение N -> ");
if (num1 % 2 != 0) num1++;
if (num2 % 2 != 0) num2--;
int leng = num2 / 2 - num1 / 2 + 1;
int[] arr = new int[leng];
EvenNumbers(arr, num1, num2);
System.Console.Write($"Натуральные четные числа от {num1} до {num2} -> ");
PrintArray(arr);
