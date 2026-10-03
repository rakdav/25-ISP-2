Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
int i = 1;//счетчик цикла
int S = 1;//сумма чисел
while (i <= n)
{
    S = S * i;
    i = i + 1;
}
Console.WriteLine($"Сумма чисел от 1 до {n}: {S}");
