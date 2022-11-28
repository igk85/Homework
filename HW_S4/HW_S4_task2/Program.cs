// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
int a;
Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int sum = 0;
int quot = a;
int digit = 0;
while (quot > 0)
{
    digit =  quot% 10;
    sum = sum + digit;
    quot = quot / 10;
}
Console.WriteLine("Сумма цифр в числе " + a + " равна " + sum);