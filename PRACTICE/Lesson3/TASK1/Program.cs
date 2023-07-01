Console.Clear();
// static int wwwwwwwww(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     return 4;
// }

int Prompt(string messege)
{
    Console.Write($"{messege}");
    return int.Parse(Console.ReadLine());
}
bool Validate(int arg1)
{
    if (arg1 < 1 || arg1 > 4)
    {
        Console.WriteLine("QQQQQQQQQQQQ");
        return false;        
    }
    return true;
}

string getXY(int quarter)
{
    switch (quarter)
    {
        case 1: return "x > 0, y > 0";
        case 2: return "x < 0, y > 0";
        case 3: return "x < 0, y < 0";
        default: return "x > 0, y < 0";
    }
}

int num = Prompt("Введите номер четверти -> ");
if (Validate(num))
{
    System.Console.WriteLine($"Значения XY равны {getXY(num)}");
}



