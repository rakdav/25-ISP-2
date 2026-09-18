////базовый
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите r:");
//double r = double.Parse(Console.ReadLine());
//double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
//Console.WriteLine($"W={W:F2}");

////средний
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите p:");
//double p = double.Parse(Console.ReadLine());
//double N=(3*y*y+Math.Sqrt(y+1))/(Math.Log(p+y)+Math.Exp(p));
//Console.WriteLine($"W={N:F2}");


////высокий
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3 + x, 1.0 / 5) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
//Console.WriteLine($"K={K:F2}");

//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//double S = Math.Sqrt(Math.Cos(4 * y * y) + 7.151);
//Console.WriteLine($"S={S:F2}");

//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите r:");
//double r = double.Parse(Console.ReadLine());
//Console.Write("Введите t:");
//double t = double.Parse(Console.ReadLine());
//double W = (4 * Math.Pow(t, 3) +Math.Log(r)) / (Math.Exp(y+r)+7.2*Math.Sin(r));
//Console.WriteLine($"W={W:F2}");
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введите t:");
    double t = double.Parse(Console.ReadLine());
    double P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, Math.E) + Math.Sqrt(x));
    Console.WriteLine($"P={P:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//double x= float.Parse(Console.ReadLine());
//float y = (float)(2 * x);
//int a = 667;
//sbyte b = (sbyte)a;
//Console.WriteLine(b);

