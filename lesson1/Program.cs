//Console.Write("Введите ваше имя:");
//string name = Console.ReadLine();
//Console.WriteLine("Меня зовут "+name);
//Console.WriteLine("Меня зовут {0}",name);
//Console.WriteLine($"Меня зовут {name}");

//Console.Write("Введите x:");
//int x= int.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//int y= Convert.ToInt32(Console.ReadLine());
//int s = x + y;
//Console.WriteLine($"{x}+{y}={s}");

//float x = 3.7F;
//double y = Math.Pow(x, 7);

//Console.Write("Введите угол в градусах:");
//double angle = double.Parse(Console.ReadLine());
//double y=Math.Sin(angle*Math.PI/180);
//Console.WriteLine($"y={y:f2}");

//Console.Write("Введите степень числа:");
//double x = double.Parse(Console.ReadLine());
//double y=Math.Exp(7*x);
//Console.WriteLine($"y={y:f2}");

//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");

//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a} - Вот какое число вы ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7\t15\t100");
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//    Console.WriteLine($"{d:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите радиус:");
//    double R = double.Parse(Console.ReadLine());
//    double D = 2 * R;
//    Console.WriteLine($"Диаметр окружности:{D:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double z = (x+((2+y)/x*x)) / (y+(1/Math.Sqrt(x*x+10)));
//    Console.WriteLine($"z={z:F2}");
//    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
//    Console.WriteLine($"q={z:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    //Console.Write("Введите количество сантиметров:");
//    //int sm=int.Parse(Console.ReadLine());
//    //int m = sm / 100;
//    //Console.WriteLine($"Полных метров {m}");
//    //Console.Write("Введите количество секунд:");
//    //int n = int.Parse(Console.ReadLine());
//    //int hour = n / 3600;
//    //int minute = n % 3600/60;
//    //int second = n%3600%60;
//    //Console.WriteLine($"{hour}:{minute}:{second}");
//    Console.Write("Введите чытерехзначное число:");
//    int n= int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b= n % 100/10;
//    int c = n % 1000/100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    Console.Write("Введите номер места: ");
    int place = int.Parse(Console.ReadLine());
    int tier = place / 120 + 1;
    int section = place % 120 / 15;
    int ps = place % 120 % 15 + 1;
    Console.WriteLine($"Ярус: {tier}  Секция: {section}  Место в секции: {ps}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}