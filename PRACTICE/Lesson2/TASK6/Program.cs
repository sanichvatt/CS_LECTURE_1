Console.Clear();
int ReadInt(string messege)
{
    System.Console.Write(messege);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}
int num = ReadInt("Введите число для проверки кратности цикла -> ");

void Fn(int num)
{
    Random rand = new Random();
    int digit;
    do
    {
        digit = rand.Next(0, 1000);
        System.Console.WriteLine(digit);
    }
    while(digit % num != 0);
}
Fn(num);