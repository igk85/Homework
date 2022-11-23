int N;
Console.Write("Введите число от 1 до 7: ");
        N = Convert.ToInt32(Console.ReadLine());
            if ((N >= 1) && (N<= 7))
            {
                if (N== 6 | N == 7) Console.WriteLine("Выходной день");
                else Console.WriteLine("Рабочий день");
            }
            else Console.WriteLine("Не верное число");
