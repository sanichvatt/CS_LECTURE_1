Console.Clear();

// Напишите программу которая принимает на вход число и проверяет кратно ли оно оновременно 7 и 23

int ReadInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ResT (int arg1, int arg2)
{
    int result = arg1 % arg2;
    return result;
}

bool AliQuot (int arg1, int arg2, int arg3)
{
    return arg1 % arg2 == 0 && arg1 % arg3 == 0;
    // if (arg1 % arg2 == 0 && arg1 % arg3 == 0)
    // {
    //     return true;
    // }
    // else { return false; }
}

int num = ReadInt("Введите число -> ");
int a = 7;
int b = 23;

if (AliQuot(num, a, b) == true)
{
    Console.Write($"{num} кратно {a} и {b}");
}
else
{
    Console.Write($"{num} не кратно {a} и {b}");
}

// int rest1 = ResT(num, a);
// int rest2 = ResT(num, b);
// if (rest1 == 0 || rest2 == 0)
// {
//     Console.Write($"{num} кратно {a} и {b}");
// }
// else 
// {
//     Console.Write($"{num} не кратно {a} и {b}");
// }