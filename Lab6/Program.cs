double DoFunc(int x)
{
    return (Math.Sqrt(x) + x) / 2;
}
double Max(double x,double y)
{
    if(x>y) return x;
    return y;
}
int OddCount(int[] mas)
{
    int count = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if(mas[i]%2==0) count++;
    }
    return count;
}
int EvenCount(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 != 0) count++;
    }
    return count;
}
int[] GetMas(int[] mas)
{
    Random rand = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rand.Next(1, 10);
    }
    return mas;
}
void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.WriteLine();
}

long Factorial(int n)
{
    long f = 1;
    for (int i = 1; i < n; i++) f *= i;
    return f;
}
//double y = (Math.Sqrt(6) + 6) / 2 + (Math.Sqrt(13) + 13) / 2 + (Math.Sqrt(21) + 21) / 2;
//double y = DoFunc(6) + DoFunc(13) + DoFunc(21);
//Console.WriteLine($"y={y:F2}");
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine()!);
//    Console.WriteLine($"z={Max(a,2*b)*Max(2*a-b,b):f2}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//int[] mas1= new int[8];
//int[] mas2= new int[8];
//mas1 = GetMas(mas1);
//mas2 = GetMas(mas2);
//Print(mas1);
//Print(mas2);
//Console.WriteLine($"Количество четных в первой {OddCount(mas1)}");
//Console.WriteLine($"Количество нечетных во второй {EvenCount(mas1)}");

double y = (2*Factorial(5)+3*Factorial(8)) / (Factorial(6)+Factorial(4));
Console.WriteLine($"y={y:f2}");