//Random rnd=new Random();
//int[,] mas = new int[4, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-5,6);
//        Console.Write($"{mas[i,j]} ");
//    }
//    Console.WriteLine();
//}
//int min = mas[0, 0];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] < min) min = mas[i, j];
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"{min}");
//Console.WriteLine();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i,j]%2==0) mas[i, j]*=2;
//        else mas[i, j] *=3;
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Random rnd = new Random();
//int n = rnd.Next(3, 10);
//int[,] mas = new int[n, n];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//double S = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (i == j) S += mas[i, j];
//    }
//}
//Console.WriteLine($"{S/mas.GetLength(0):F2}");
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i,j]<0) mas[i, j] = Math.Abs(mas[i,j]);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//S = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (i == j) S += mas[i, j];
//    }
//}
//Console.WriteLine($"{S / mas.GetLength(0):F2}");

//30 вариант базовый уровень
//Random rnd = new Random();
//int[,] mas = new int[rnd.Next(4,9),rnd.Next(4,9)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//int count = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    if (mas[i, 1] >= 0) count++;
//}
//Console.WriteLine($"Количество отрицательных элементов во втором столбце {count}");

//30 вариант средний уровень
try
{
    Random rnd = new Random();
    Console.Write("Введите количество строк:");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов:");
    int m = int.Parse(Console.ReadLine()!);
    int[,] mas = new int[n, m];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = rnd.Next(1, 10);
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < mas.GetLength(0); i++)
    { 
        for (int j = 0; j < mas.GetLength(1)-1; j++)
        {
            for(int k = j + 1; k < mas.GetLength(1); k++)
            {
                if (mas[i, j] > mas[i,k])
                {
                    int temp = mas[i, j];
                    mas[i, j] = mas[i, k];
                    mas[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int max = -1;
    int row = -1;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int k = 1;
        int maxk = 0;
        for (int j = 1; j < mas.GetLength(1); j++)
        {
            if (mas[i, j - 1] == mas[i, j]) k++;
            else
            {
                int temp = k;
                if (temp>maxk) maxk = temp;
                k = 1;
            }
        }
        Console.WriteLine(maxk);
        if (maxk > max)
        {
            max = maxk;
            row= i;
        }
    }
    Console.WriteLine();
    Console.WriteLine(row);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
