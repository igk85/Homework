// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
Random rand = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
    string number = Convert.ToString(array[i]);

    Console.Write(" " + number.PadLeft(4, ' ') + ",");
}
Console.WriteLine("]");
Console.WriteLine(" ");


