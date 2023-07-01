// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
int Prompt(string messege)
{
    Console.Write($"{messege}");
    return int.Parse(Console.ReadLine());
}

int x1 = Prompt("Введите X1: ");
int y1 = Prompt("Введите Y1: ");
int z1 = Prompt("Введите Z1: ");
int x2 = Prompt("Введите X2: ");
int y2 = Prompt("Введите Y2: ");
int z2 = Prompt("Введите Z2: ");


double dx = x2 - x1;
double dy = y2 - y1;
double dz = z2 - z1;
double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
Console.WriteLine($"Расстояние между точками равно {distance:f2}");