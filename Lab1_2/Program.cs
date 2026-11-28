try
{
    Console.Write("Введите первую переменную:");
    double x=double.Parse(Console.ReadLine());
    Console.Write("Введите вторую переменную:");
    double y=double.Parse(Console.ReadLine());
    double Avg = (Math.Pow(x, 3) + Math.Pow(y, 3)) / 2;
    Console.WriteLine($"Среднее арифметическое:{Avg:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
