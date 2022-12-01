// 12. Удалить вторую цифру трёхзначного числа

Console.Clear();

Console.WriteLine("Start");

int Value = new Random().Next(100, 1000); //[100,999]
int a = Value / 100;
int b = (Value / 10) % 10;
int c = Value % 10;
int Result = a * 10 + c;

Console.WriteLine(Value);
Console.WriteLine(Result);
Console.WriteLine("End");