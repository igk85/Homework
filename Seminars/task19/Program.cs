// (19).21. Программа проверяет пятизначное число на палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if((numberA < 10000)^(numberA > 100000))
{
    Console.WriteLine("Число " + numberA + " не является пятизначным");
}
else
{
    int a = (numberA / 10000);
    Console.WriteLine(a);
    int b = (numberA / 1000) % 10;
    Console.WriteLine(b);
    int c = (numberA % 100) / 10;
    Console.WriteLine(c);
    int d = (numberA % 10);
    Console.WriteLine(d);
        if((a == d) && (b == c))
        {
            Console.WriteLine("Число " + numberA + " - полиндром");
        }
        else
        {
            Console.WriteLine("Число " + numberA + " - не полиндром");
        }
}