// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int size = 123;
int min = -100;
int max = 200;

int[] FillArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void PrintCountArray (int[] arr)
{
    int count =1;
    System.Console.WriteLine();
     for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] < 100) count++;
    }
        System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    System.Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));

// int[] array = new int[123];
// int count=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// for (int j = 0; j < array.Length; j++)
// {
//     if(array[j] > 9 & array[j] < 100) count = count + 1;
// }
// Console.WriteLine();
// Console.Write("Массив совержит следующее количество элементов из отрезка [10,99] - ");
// Console.Write(count);