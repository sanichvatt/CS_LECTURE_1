// Напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

System.Console.Clear();
int runNum = new Random().Next(10, 100);

int Max(int Num)
{
    int num1 = runNum % 10;
    int num2 = runNum / 10 % 10;
    if (num1 > num2) return num1;
    else return num2;
}

System.Console.Write($"{runNum} -> ");
System.Console.Write(Max(runNum));
