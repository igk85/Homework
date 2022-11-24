// Поскольку вопрос задачи найте третью цифру, не разряд - отчет в решении веду слева направо.
int N , M, S;

Console.Write("Введите любое число : ");
        N = Convert.ToInt32(Console.ReadLine());
        M= N.ToString().Length;
        if((M <= 2))
        {
            Console.WriteLine("Третьей цифры нет ");
        }
        else 
        {
            S = (N / Convert.ToInt32(Math.Pow(10, M - 3)) % 10);
            Console.WriteLine("Всего цифр {0}", M);
            Console.WriteLine("{0} третья цифра ", S);
        }
