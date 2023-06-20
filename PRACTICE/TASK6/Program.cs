//Напишите программу которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке (-N;+N)

Console.Write("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i <= num) 
{
    Console.WriteLine(i);
    i = i + 1;
}

