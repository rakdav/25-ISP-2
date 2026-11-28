using OurLibrary;
Random random=new Random();
int[] mas=new int[random.Next(10,30)];
for(int i=0;i<mas.Length;i++)
{
    mas[i]=random.Next(10,50);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Console.WriteLine($"Сумма массива:{OurClassLibrary.MultiMatrix(mas)}");
