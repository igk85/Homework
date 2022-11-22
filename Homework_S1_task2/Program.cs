internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, z;//создали три целых числа
        int max;
        Console.WriteLine("Введите три числа : ");
        x = Convert.ToInt32(Console.ReadLine());

        y = Convert.ToInt32(Console.ReadLine());

        z = Convert.ToInt32(Console.ReadLine());


        if (x >= y)
        {
            if (z >= x)
            {
                max = z;
            }
            else
            {
                max = x;
            }
        }
        else
        {
            if (z >= y)
            {
                max = z;
            }
            else
            {
                max = y;
            }
            Console.Write("Наибольшее число ");
            Console.WriteLine(max);
        }
    }
}