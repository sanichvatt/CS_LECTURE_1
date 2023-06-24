Console.Clear();
// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int ReadInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// int Sum(int arr)
// {
//     int sum = 0;
//     int lin = arr.Length;
//     for (int i = 0; i < lin; i++)
//     {
//         sum += arr[i];
//     }
//     return sum;
// }
int[] arre = new int[5];
int lin = arre.Length;
for (int i = 0; i < arre.Length; i++)
{
    arre[i] = ReadInt($"Введите {i + 1} элемент массива: ");
}
int Sum(int ar)
{
    int sum = 0;
    for (int i = 0; i < lin; i++)
    {
        sum += ar[i];
    }
    return sum;
}
System.Console.WriteLine($"Сумма элементов массива -> {Sum(arre)}, среднее значение -> {Sum(arre) / arre.Length}");
