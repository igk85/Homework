//17. По двум заданным числам проверять является ли одно квадратом другого
int numberA = 10;
int numberB = 100;
if(numberB == numberA * numberA)
{
    Console.WriteLine("Число "+numberB+" является квадратом числа "+numberA);
}
else
{
    Console.WriteLine("Число "+numberB+" не является квадратом числа "+numberA);
}