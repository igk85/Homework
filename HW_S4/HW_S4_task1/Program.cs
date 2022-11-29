//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
ToDegree(a, b);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}