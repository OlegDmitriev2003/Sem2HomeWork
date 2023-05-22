Console.Clear();
Console.Write("Введите трёхзначное число: ");
int Num = int.Parse(Console.ReadLine()!);

if (Num < 99 || Num > 999 )
    Console.WriteLine("Число не трёхзначное");
else
    {
    Num = (Num/10)%10;
    Console.Write($"{Num} - вторая цифра");
    }