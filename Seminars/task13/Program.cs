//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

internal class Program
{
    private static void Main(string[] args)
    {
        int Number1 = 21;
        int Number2 = 5;

        int Reminder = Number1 % Number2;
        if (Reminder != 0)
        {
            Console.WriteLine(Reminder);
        }

        else

        {
            Console.WriteLine("Кратно");
        }
    }
}