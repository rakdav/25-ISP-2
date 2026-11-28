using System.Runtime.InteropServices;

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
    for (int i = 1; i <=n; i++) f *= i;
    return f;
}

long RecursiveFactorial(int n)
{
    if (n == 0 || n == 1) return 1;
    return n * RecursiveFactorial(n - 1);
}
int DayCount(int g,int m)
{
    switch(m)
    {
        case 1: case 3: case 5: case 7: case 8: case 10: case 12: return 31;
        case 2: if (g % 4 == 0) return 29;
                return 28;
        default: return 30;
    }
}

void Increment(int n)//передача параметров по значению
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}
//При передаче аргументов параметрам по значению параметр метода получает не саму переменную, а ее копию и далее работает с этой копией независимо от самой переменной.
void Swap(int a,int b)
{
    int temp=a; 
    a=b; 
    b=temp;
}
//При передаче значений параметрам по ссылке метод получает адрес переменной в памяти. И, таким образом, если в методе изменяется значение параметра, передаваемого по ссылке, то также изменяется и значение переменной, которая передается на его место.
void SwapRef(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
//Выходные параметры. Модификатор out
void Sum(int x,int y,out int result)
{
    result = x + y;
}

//Входные параметры. Модификатор in
//Модификатор in указывает, что данный параметр будет передаваться в метод по ссылке, однако внутри метода его значение параметра нельзя будет изменить. 
void GetRevtangleData(in int width,in int height,out int rectArea,out int rectPerimetr)
{
    //width = 67;
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}
//Массив параметров и ключевое слово params
void Summa(params int[] mas)
{
    int result = 0;
    foreach(int i in mas) result+= i;
    Console.WriteLine(result);
}

//Рекурсия


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

//double y = (2*Factorial(5)+3*Factorial(8)) / (Factorial(6)+Factorial(4));
//Console.WriteLine($"y={y:f2}");
//int x = 5;
//int y = 6;
//Console.WriteLine($"x={x} y={y}");
//Swap(x, y);
//Console.WriteLine($"x={x} y={y}");
//SwapRef(ref x,ref y);
//Console.WriteLine($"x={x} y={y}");
//int number;
//Sum(15,10,out number);
//Console.WriteLine(number);
//try
//{
//    int x = int.Parse(Console.ReadLine()!);
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//int x;
//Console.Write("Введите x:");
//int.TryParse(Console.ReadLine(), out x);
//Console.WriteLine(x);

//int w = 10;
//int h = 20;
//int area, perimetr;
//GetRevtangleData(w, h, out area, out perimetr);
//Console.WriteLine($"Площадь прямоугольника: {area}");
//Console.WriteLine($"Периметр прямоугольника: {perimetr}");

//int[] nums = { 1, 2, 3, 4, 5 };
//Summa(nums);
//Summa(1, 4, 6, 4, 3, 89);
//Summa(4, 6, 46, 6);

Console.WriteLine(Factorial(6));
Console.WriteLine(RecursiveFactorial(6));