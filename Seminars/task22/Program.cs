// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = ReadInt ("Введите координату X числа 1: ");
int y1 = ReadInt ("Введите координату У числа 1: ");
int z1 = ReadInt ("Введите коордитату Z числа 1: ");
int x2 = ReadInt ("Введите координату X числа 2: ");
int y2 = ReadInt ("Введите координату У числа 2: ");
int z2 = ReadInt ("Введите коордитату Z числа 2: ");

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

double lenght = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"Длина отрезка {lenght}");

// Функция ввода ссобщения
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}