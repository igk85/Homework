// 24. Найти кубы чисел от 1 до N

Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    int x;
    int i = 1;
     while (i <= N)
     {
        x = i * i  * i;
        i++;
        Console.WriteLine(" "+ x);
     }

