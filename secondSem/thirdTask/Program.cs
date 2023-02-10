/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.Write("Введите цифру, соответствующую дню недели: ");
int digit = int.Parse(Console.ReadLine()!);

if (digit > 7 || digit < 1 )
{
    Console.Write("Дней в неделе семь... ");
}

    switch (digit)
{
    case 6:
       Console.WriteLine("Да");
       break;
    case 7:
       Console.WriteLine("Да");
       break;    
    default:
       Console.WriteLine("Нет");
       break;
}

