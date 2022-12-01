//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = 8;
if ((9 > number)^(number > 100))
{
    Console.WriteLine("Число не из диапазона от 10 до 99");
}
else
{
    int a = number/10;
    int b = number%10;
        if(a>b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
}