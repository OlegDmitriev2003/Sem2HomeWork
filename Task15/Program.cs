Console.Clear();
Console.Write("Введите цифру дня недели: ");
int Num = int.Parse(Console.ReadLine()!);
if (Num == 6 || Num == 7)
    Console.WriteLine("Это выходной");
else
    Console.WriteLine("Это не выходной");