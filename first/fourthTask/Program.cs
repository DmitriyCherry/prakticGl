/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/


int numberN1 = 5;
Console.Write($"Введено число: {numberN1}: ");

for (int i = 1; i <= numberN1; i++)
{
    if (i % 2 == 0)
{
   Console.Write(" " + i);   
}
}
Console.WriteLine();

int numberN2 = 8;
Console.Write($"Введено число: {numberN2}: ");

for (int i = 1; i <= numberN2; i++)
{
    if (i % 2 == 0)
{
   Console.Write(" " + i);   
}
}
