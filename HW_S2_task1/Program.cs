int N, S;
Console.Write("Введите число N: ");
        N = Convert.ToInt32(Console.ReadLine());
        if((N < 100)^(N > 999))
        {

            Console.WriteLine("{0} Не является трехзначным числом ",N);

        }

        else

        {
            S=(N / 10) % 10;
            Console.WriteLine("{0} второе число ", S);

        }
