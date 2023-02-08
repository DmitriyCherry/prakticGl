/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите любое целое число: ");
int count = int.Parse(Console.ReadLine()!);

if (count % 2 == 0)
{
    if (count != 0)
    {
        Console.WriteLine($"Введенное число {count} - чётное.");
    }else
    {
        Console.WriteLine($"Введенное число {count} является нулём.");
    }    
}else
{
    Console.WriteLine($"Введенное число {count} - нечётное.");
}

