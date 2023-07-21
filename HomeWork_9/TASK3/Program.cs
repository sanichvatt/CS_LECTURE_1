// Задача 3: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.Clear();
double ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    double arg = Convert.ToDouble(inputedString);
    return arg;
}

double ack = 0;
double Ackerman(double arg1, double arg2)
{
    if (arg1 == 0) return ack = arg2 + 1;
    else if (arg2 == 0) return ack = Ackerman(arg1 - 1, 1);
    ack = Ackerman(arg1 - 1, Ackerman(arg1, arg2 - 1));
    return ack;
}

double num1 = ReadInt("Введите значение n -> ");
double num2 = ReadInt("Введите значение m -> ");
double number = Ackerman(num1, num2);
System.Console.WriteLine($"Функция Аккермана А({num1},{num2}) = {number}");