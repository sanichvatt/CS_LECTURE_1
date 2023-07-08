Console.Clear();
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ComplitArray(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write("Введите значение в массив M: ");
        matr[i] = Convert.ToInt32(Console.ReadLine());
    }    
    return matr;
}
void PrintArray(int[] matr)
{

    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"{matr[i]}, ");        
    }
    System.Console.WriteLine();
}
bool CheckNum(int n)
{
    if (n > 0) return true;
    else return false;
}

int CounterArray(int[] matr)
{
    int count = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        if (CheckNum(matr[i])) count = count + 1;
    }
    return count;
}

System.Console.Write("Введите длину массива M: ");
int leng = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[leng];
ComplitArray(arr);
int numPoz = CounterArray(arr);
PrintArray(arr);
System.Console.WriteLine($"Элементов больше 0 = {numPoz}");

