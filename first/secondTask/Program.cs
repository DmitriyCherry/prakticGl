/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


int a1 = 2; int b1 = 3; int c1 = 7;
int a2 = 44; int b2 = 5; int c2 = 78;
int a3 = 22; int b3 = 3; int c3 = 9;

int max1 = a1;
if (b1 > a1)
{
    max1 = b1;
    if (b1 < c1)
    {
        max1 = c1;
    }
}else if (a1 < c1)
{
    max1 = c1;
}
Console.WriteLine($"Максимальным из приведенного ряда чисел является: {max1}");

int max2 = a2;
if (b2 > a2)
{
    max2 = b2;
    if (b2 < c2)
    {
        max2 = c2;
    }
}else if (a2 < c2)
{
    max2 = c2;
}
Console.WriteLine($"Максимальным из приведенного ряда чисел является: {max2}");

int max3 = a3;
if (b3 > a3)
{
    max3 = b3;
    if (b3 < c3)
    {
        max3 = c3;
    }
}else if (a3 < c3)
{
    max3 = c3;
}
Console.WriteLine($"Максимальным из приведенного ряда чисел является: {max3}");

