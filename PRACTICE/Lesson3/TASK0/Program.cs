Console.Clear();

static int wwwwwwwww(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int Prompt(string messege)
{
    Console.Write($"{messege} > ");
    return int.Parse(Console.ReadLine());
}
bool ValidateCoords(int x1, int y1)
{
    if (x1 == 0 || y1 == 0)
    {
        Console.WriteLine("Одна из координат равна 0");
        return false;        
    }
    return true;
}

int x = Prompt("Введите X");
int y = Prompt("Введите Y");
if (ValidateCoords(x, y))
{
    int quarter = wwwwwwwww(x, y);
    System.Console.WriteLine($"Четверть номер {quarter}");
}