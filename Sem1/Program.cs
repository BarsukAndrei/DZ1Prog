﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if(a > b)
{
    Console.WriteLine("max = " + a);
}
if(a < b)
{
    Console.WriteLine("max = " + b);
}
if(a == b)
{
    Console.WriteLine("А ты хорош");
} */

/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int c = int.Parse(Console.ReadLine()!);

int max = 0;

if(max < a)
{
    max = a;
}
if(max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
Console.WriteLine(max); */

/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if(a%2 == 0)
{
    Console.WriteLine("Это число четное");
}
if(a%2 != 0)
{
    Console.WriteLine("Это число нечетное");
}
if(a%2 == 1)
{
    Console.WriteLine("Это число нечетное");
}