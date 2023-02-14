// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double MyMathPow (double arg1, double arg2)
{   
    double result = 1;
    for (double i = 1; i <= arg2; i++)
    {        
        result *= arg1;
    }      
    return result;
}

Console.Write("Введите любое число для возведения его в степень: ");
int value = int.Parse(Console.ReadLine()!);
Console.Write("Введите любое число, котторое будет соответствовать степени возведения: ");
int powValue = int.Parse(Console.ReadLine()!);
int result = Convert.ToInt32(MyMathPow(value, powValue));
Console.Write($"Результат: {result}");
