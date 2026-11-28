//Person tom=new Person();
//tom.name = "Vasia";
//tom.age = 18;
//Console.WriteLine(tom.name);
//Console.WriteLine(tom.age);
//struct Person
//{
//    public string name;
//    public int age;
//}
DateTime st = DateTime.Parse(Console.ReadLine()!);
DateTime start = new DateTime(2018, 11, 1);
DateTime end = DateTime.Now;

TimeSpan diff=end-start;
Console.WriteLine($"{diff.TotalDays/365:F0}");

Comp[] comps = new Comp[5];
for (int i = 0; i < comps.Length; i++)
{
    Console.Write("Введите название компьютера:");
    comps[i].name = Console.ReadLine()!;
    Console.Write("Введите частоту:");
    comps[i].frequency = int.Parse(Console.ReadLine()!);
    Console.Write("Введите память:");
    comps[i].memory = int.Parse(Console.ReadLine()!);
    Console.Write("Введите наличие DVD: Да/Нет?");
    string dvd = Console.ReadLine()!;
    if (dvd == "Да") comps[i].DVD = true;
    else comps[i].DVD = false;
    Console.Write("Введите цену:");
    comps[i].price =decimal.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите дату:");
    comps[i].db = DateTime.Parse(Console.ReadLine()!);
}
for (int i = 0; i < comps.Length; i++)
{
    if (comps[i].DVD) comps[i].Print();
}
struct Comp
{
    public string name;
    public int frequency;
    public int memory;
    public bool DVD;
    public decimal price;
    public DateTime db;
    public void Print()
    {
        Console.WriteLine($"Название:{name}, частота:{frequency}, память {memory}, {((DVD)?"DVD":"")}, цена:{price}");
    }

}