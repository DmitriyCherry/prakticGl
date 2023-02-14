// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе:
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigits (int arg)
{
    int sum = 0;
    int forIf = arg /10;
    if (forIf == 0)
    {
        sum = arg;
    }
    
    for (int i = 0; forIf > 0; i++)
    {               
        arg = arg % 10;         
        sum += arg + (forIf % 10);
        forIf /= 10;
        arg /= 10;       
    }
    return sum;
}

Console.Write("Введите любое целое число: ");
int count = int.Parse(Console.ReadLine()!);
int result = SumDigits(count);
Console.Write($"Результат работы функции: {result}");