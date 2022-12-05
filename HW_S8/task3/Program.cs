//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);
Console.WriteLine();

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[z, i, j] += count;
                count += 3;
            }
        }
    }
}

// Функция вывода индекса элементов 3D массива

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[i, j, z]}({i},{j},{z}) ");
            }
        }
    }
}