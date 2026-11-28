//char c = 'A';
//Console.WriteLine((int)c);
//for (int i = 35; i < 100; i++)
//    Console.Write((char)i+" ");
//Console.WriteLine();
//Console.WriteLine(char.IsDigit('5'));
//Console.WriteLine(char.IsLetter('X'));

//базовый уровень 30 вариант
//char[,] matrix = new char[5, 7];
//Random random=new Random();
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = (char)random.Next(40, 70);
//        Console.Write(matrix[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//int sum = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (char.IsDigit(matrix[i, j])) sum += int.Parse(matrix[i,j].ToString());
//    }
//}
//Console.WriteLine("Sum="+sum);


//средний уровень 30 вариант
char[] mas = new char[15];
Console.Write("Введите строку:");
string stroka = Console.ReadLine()!;
mas = stroka.ToArray();
Console.Write("Введите строку поиска:");
string word=Console.ReadLine()!;
int count = 0; 
int wordLength = word.Length;
for (int i = 0;i < mas.Length - wordLength; i++)
{
    bool match=true;
    for (int j = 0;j< wordLength; j++)
    {
        if (mas[i + j] != word[j])
        {
            match=false; 
            break;
        }
    }
    if (match) count++;
}
Console.WriteLine($"Cлово {word} встречается в массиве {count} раз.");