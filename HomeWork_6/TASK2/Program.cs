Console.Clear();
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}
int b1 = Prompt("b1 = ");
int k1 = Prompt("k1 = ");
int b2 = Prompt("b2 = ");
int k2 = Prompt("k2 = ");
double x = 0;
double y = 0;

// (k1 * x + b1 - b2) / k2 = x 

x = (k1 * x + b1 - b2) / k2;
y = k1 * x + b1;
System.Console.WriteLine($"Пересечение линейных функций в точке -> ( {x}; {y} )");

//Вроде бы задачу решил, но чувствую что, в чем то подвох. Не ясно, где же тут массив одномерный применить...