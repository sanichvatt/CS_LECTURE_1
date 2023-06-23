// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому
// 30, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.Clear();
// System.Console.WriteLine("Введите два числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

int ReadInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// int ResT (int arg1, int arg2)
// {
//     int result = arg1 % arg2;
//     return result;
// }

int num1 = ReadInt("Введите первое число -> ");
int num2 = ReadInt("Введите второе число -> ");
double rest = num1 % num2;

// int rest = ResT(num1, num2);

if (rest == 0) Console.Write($"{num1}, {num2} -> кратно");
else Console.Write($"{num1}, {num2} -> не кратно, остаток {rest}");
