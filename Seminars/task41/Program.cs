﻿

// 41. Выяснить являются ли три числа сторонами треугольника

Random rand = new Random();
int  a = rand.Next(1, 50);
Console.WriteLine ("Число А = " + a);
int b = rand.Next(1, 50);
Console.WriteLine ("Число B = " + b);
int c =rand.Next(1,50);
Console.WriteLine ("Число C = " + c);

if ((a + b > c) && (a + c > b) && (b + c > a)) Console.WriteLine("Числа являются сторонами треугольника");
else Console.WriteLine("Числа не являются сторонами треугольника");
