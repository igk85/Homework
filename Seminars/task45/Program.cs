// 45. Показать числа Фибоначчи

int num = 15;
int f1 = 1;
int f2 = 1;
int sum = 0;

for (int i = 0; i<= num; i++ )
{
    sum = f1 + f2;
    Console.Write (sum + " ");
    f1 = f2;
    f2 = sum;
}

//Фибоначчи

// int f(1) = 1;
// int f(2) = 1;
// int f(n)=f(n-1)+f(n-2);

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }
// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine($"f({i})={Fibonacci(i)}");
// }