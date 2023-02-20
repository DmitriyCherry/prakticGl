// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void StringThing(int[] arg)
{    
for (int i = 0; i < arg.Length; i++)
{
    string thing = ", ";    
    if (i == 0)
        {
            Console.Write("[" + arg[i] + thing);
        }else
        {
            if (i == arg.Length - 1)
            {
                Console.Write(arg[i] + "]");
            }else
        {
            Console.Write(arg[i] + thing);
        }
        }            
}
}

int AboveZero (int[] arg)
{    
    int sum = 0;
    for (int i = 0; i < arg.Length; i++)
{
    int temp = arg[i];
    if (temp > 0 )
    {
        sum ++;
    }
}
    return sum;
}

Console.Write("Введите число М: ");
int elemts = int.Parse(Console.ReadLine()!);
int[] myArray = new int [elemts];
for (int i = 0; i < elemts; i++)
{
    myArray[i] = int.Parse(Console.ReadLine()!);
}
StringThing(myArray);
int result = AboveZero(myArray);
Console.Write("--> " + result);