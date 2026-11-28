Console.Write("Введите массу:");
double m = double.Parse(Console.ReadLine()!);
Console.Write("Введите скорость:");
double s = double.Parse(Console.ReadLine()!);
Body body = new Body(m,s);
body.Print();

class Body
{
    private double weight;
    public double Weight
    {
        private get { return weight; }
        set { if(value>0) weight = value; }
    }
    private double speed;
    public double Speed
    {
        private get { return speed; }
        set { speed = value; }
    }
    public Body(double _w,double _s)
    {
        Weight= _w;
        Speed = _s;
    }
    private double Energy()
    {
        return weight * speed*speed/2;
    }
    public void Print()
    {
        Console.WriteLine($"Тело массой {weight}, двигающееся со скоростью {speed} имеет кинетическую энергию {Energy} Дж");
    }
}
