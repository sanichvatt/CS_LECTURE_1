Console.Clear();
int Prompt(string messege)
{
    Console.Write($"{messege}");
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите X1: ");
int y1 = Prompt("Введите Y1: ");
int x2 = Prompt("Введите X2: ");
int y2 = Prompt("Введите Y2: ");

double dx = x2 - x1;
double dy = y2 - y1;
double distance = Math.Sqrt(dx * dx + dy * dy);
Console.WriteLine($"Расстояние между точками равно {distance: f2}");