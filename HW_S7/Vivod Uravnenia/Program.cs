//Доделать ввод многочлена

int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

void PrintTriangle(int[,] triangle)
{
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] != 0)
        Console.Write($"{triangle[i, j],5}");
    }
    Console.WriteLine();
  }
}

int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

int[,] tr = CreateTriangle(10);
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, 3);

System.Console.WriteLine(String.Join(' ', koeff));

System.Console.WriteLine(koeff.Length);

for (int i = 0; i < koeff.Length; i++)
{

    if (i == 0 && koeff[i] == 1)
    {
         Console.Write($"a^{koeff.Length - 1 - i} + ");
    }
    else 
    {
        if ((koeff.Length - 1 - i) == 0 && koeff[i] == 1)
        {
        Console.Write($"b^{i} ");
        }
        else
        { if (i==1)
            { 
            Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b + ");
            }
            else 
            {
                if ((koeff.Length - 1 - i) == 1)
                {
                Console.Write($"{koeff[i]}*a*b^{i} + ");
                }
                else 
                {
                Console.Write($"{koeff[i]}*a^{koeff.Length - 1 - i}*b^{i} + ");
                }
            }
        }        
    }            
}
Console.WriteLine("");
