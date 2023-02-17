// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int SumNegElmts (int[] arg)
{
    int sumNegative = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] % 2 != 0)
        {
            sumNegative += arg[i];
        }
    }
    return sumNegative;
}   

Console.Write("Введите количество эелментов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
int[] myArray = new int [elements];
for (int i = 0; i < elements; i++)
{
    myArray[i] = new Random().Next(0, 1000);
    string thing = ", ";    
    if (i == 0)
        {
            Console.Write("[" + myArray[i] + thing);
        }else
        {
            if (i == elements - 1)
            {
                Console.Write(myArray[i] + "]");
            }else
        {
            Console.Write(myArray[i] + thing);
        }
        }            
}
int result = SumNegElmts(myArray);
Console.Write($"--> {result}");