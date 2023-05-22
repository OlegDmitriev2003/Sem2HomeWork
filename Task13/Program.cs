Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

if (Num < 99)
    Console.WriteLine("Третьей цифры нет");
else
{
while (Num > 999)
    Num = Num / 10;
Num = Num % 10;
Console.WriteLine($"{Num} - третье число");

}