DayTime dayTime = DayTime.Morning;
if(dayTime==DayTime.Morning)
    Console.WriteLine("Доброе утро!");
else
    Console.WriteLine("Привет!");

DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Sub);     // 5
DoOperation(10, 5, Operation.Mult);     // 50
DoOperation(10, 5, Operation.Div);       // 2
void DoOperation(double x,double y, Operation op)
{
    double result = op switch {
        Operation.Add=>x+y,
        Operation.Sub=>x-y,
        Operation.Mult=>x*y,
        Operation.Div=>x/y
        };
    Console.WriteLine(result);
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

enum Operation
{
    Add,
    Sub,
    Mult,
    Div
}


