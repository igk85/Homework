// 24. Найти кубы чисел от 1 до N

// Console.Write("Введите число N: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("");
//     int x;
//     int i = 1;
//      while (i <= N)
//      {
//         x = i * i  * i;
//         i++;
//         Console.WriteLine(" "+ x);
//      }

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}