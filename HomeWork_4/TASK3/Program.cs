// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] IntArray(int length)
{
    int[] arry = new int[8];
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = Convert.ToInt32(Console.ReadLine());        
    }
    return arry;
}


Console.WriteLine ($"Введите массив чисел");
int[] arr8 = IntArray(8);
for (int i = 0; i < arr8.Length; i++)
{
    Console.Write($"{arr8[i]}, ");
}