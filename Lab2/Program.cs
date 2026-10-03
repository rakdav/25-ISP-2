//bool A = true;
//bool B = false;
//bool C = false;
//Console.WriteLine(!A||A&&(B||C));
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    Console.WriteLine(x*x+y*y<=4);
//    Console.WriteLine((x>=0)||(y*y!=4));
//    Console.WriteLine((x >= 0) && (y * y != 4));
//    Console.WriteLine((x*y!=0)&&(y>x));

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double y;
//    if (x > 0) y = Math.Sin(x) * Math.Sin(x);
//    else y = 1 - 2 * Math.Sin(x * x);
//    Console.WriteLine($"y={y:F2}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = b * b - 4 * a * c;
//    if (d > 0)
//    {
//        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//        Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
//    }
//    else if (d == 0)
//    {
//        double x = -b/ (2 * a);
//        Console.WriteLine($"x={x:F2}");
//    }
//    else Console.WriteLine();
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    if(x < 4) Console.WriteLine("Первая область");
//    else Console.WriteLine("Вторая область");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if(x>y)
//    {
//        max = x;
//        min = y;
//    }
//    else
//    {
//        max = y;
//        min = x;
//    }
//    Console.WriteLine($"max={max}, min={min}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    if((a<b)&&(b<c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("Не выполняется!");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите m:");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;
//    int c = m % 10;
//    if((a==4||b==4||c==4)|| (a == 7 || b == 7 || c == 7)) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//    if((a==3||b==3||c==3)||(a == 6 || b == 6 || c == 6)||
//        (a == 9 || b == 9 || c == 9)) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//вариант 30 базовый
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    if(n%2==0||n%10==7) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//вариант 30 средний
//try
//{
//    Console.Write("Введите a:");
//    int a = int.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    int b = int.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    int c = int.Parse(Console.ReadLine());
//    int max = a;
//    if((b>a)&&(a>c)) max = b;
//    else if ((c > a) && (c > b)) max = c;
//    Console.WriteLine($"max={max}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//вариант 30 повышенный

//try
//{
//    Console.Write("Введите x:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    if((y<=x)&&(y<=-x)&&(y>=1))
//    {
//        Console.WriteLine("Точка принадлежит области");
//    }
//    else
//    {
//        Console.WriteLine("Точка не принадлежит области");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    Console.WriteLine((x>y)? $"{x}больше {y}" : $"{x} меньше {y}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите номер дня недели:");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("Понедельник");
//            break;
//        case 2:
//            Console.WriteLine("Вторник");
//            break;
//        case 3:
//            Console.WriteLine("Среда");
//            break;
//        case 4:
//            Console.WriteLine("Четверг");
//            break;
//        case 5:
//            Console.WriteLine("Пятница");
//            break;
//        case 6:
//            Console.WriteLine("Суббота");
//            break;
//        case 7:
//            Console.WriteLine("Воскресенье");
//            break;
//        default:
//            Console.WriteLine("Нет такого дня недели");
//            break;
//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите номер месяца:");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 12:case 1:case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3: case 4:case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6:case 7:case 8:
//            Console.WriteLine("Лето");
//            break;
//        case 9:case 10:case 11:
//            Console.WriteLine("Осень");
//            break;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//вариант 28. Базовый уровень
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.WriteLine((x<3)||(x>3));

//вариант 27. Средний уровень
//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine(a<0);

//вариант 28. Высокий уровень
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine((y>=0)&&((y>=x+1)&&(y<=x+2)||(y<=-x+1)&&(y<=-x+2)));

//try
//{
//    Console.Write("Введите номер карты");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите номер масти");
//    int m = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 6:
//            Console.Write("Шестерка ");
//            break;
//        case 7:
//            Console.Write("Семерка ");
//            break;
//        case 8:
//            Console.Write("Восьмерка ");
//            break;
//        case 9:
//            Console.Write("Девятка ");
//            break;
//        case 10:
//            Console.Write("Десятка ");
//            break;
//        case 11:
//            Console.Write("Валет ");
//            break;
//        case 12:
//            Console.Write("Дама ");
//            break;
//        case 13:
//            Console.Write("Король ");
//            break;
//        case 14:
//            Console.Write("Туз ");
//            break;
//        default:
//            Console.WriteLine("Нет такой карты");
//            break;
//    }
//    switch (m)
//    {
//        case 1:
//            Console.WriteLine("пик");
//            break;
//        case 2:
//            Console.WriteLine("треф");
//            break;
//        case 3:
//            Console.WriteLine("бубен");
//            break;
//        case 4:
//            Console.WriteLine("червей");
//            break;
//        default:
//            Console.WriteLine("Нет такой масти");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите число:");
//    double x = double.Parse(Console.ReadLine());
//    if(x%100>=11&& x % 100 <= 14) Console.WriteLine($"{x} рублей");
//    else
//    {
//        switch (x % 10)
//        {
//            case 1:
//                Console.WriteLine($"{x} рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine($"{x} рубля");
//                break;
//            default:
//                Console.WriteLine($"{x} рублей");
//                break;
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.Write("Введите число:");
//int x = int.Parse(Console.ReadLine());
//switch (x)
//{
//    case 1:
//        {
//            double R1=6, R2 = 10, R3 = 2;
//            double RPosl=R1+ R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1*R2*R3)/(R2*R3 + R1*R3 + R1*R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    case 2:
//        {
//            double R1 = 3, R2 = 5, R3 = 7;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    case 3:
//        {
//            double R1 = 4, R2 = 12, R3 = 8;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    default: break;
//}

Console.Write("Введите номер варианта:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
double a = 0, b = 0, z = 0,y=0;
switch (n)
{
    case 1:
        {
            a = 1.5; b = 5.7; z =Math.Tan(Math.Abs(Math.Tan(b*x))) ;
        }
        break;
    case 2:
        {
            a = 3.7; b = 8.4; z = Math.Tan(Math.Abs(Math.Tan(b * x)));
        }
        break;
    case 3:
        {
            a = 4.4; b = 5.6; z = Math.Tan(Math.Abs(Math.Tan(b * x)));
        }
        break;
    default: break;
}
if (x <= a)
{
    y = Math.Pow(a, 3) + Math.Atan(Math.Pow(Math.Sin(b * x), 3)) + Math.Pow(Math.Cos(x * x), 2);
}
else if (x > a && x < Math.Log(b))
{
    y = Math.Sqrt((a + b * x) + 2) + Math.Sin(z * x);
}
else if (x >= Math.Log(b))
{
    y = Math.Atan(a + b * x + z);
}
Console.WriteLine($"y = {y:F2}");