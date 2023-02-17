// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76


double DiffElArray (double[] arg)
{     
double maxEl = arg[0];
    for (int i = 0; i < arg.Length; i++)
    {     
        if (arg[i] > maxEl)
        {
            maxEl = arg[i];            
        }
    }
double minEl = arg[0];
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] < minEl)
        {
            minEl = arg[i];            
        }
    } 
double diff = maxEl - minEl;
return diff;
}

double RandomDouble(double minValue, double maxValue)
{
var randomValue = new Random();
var randomDouble = randomValue.NextDouble();
double randomRangeDouble = randomDouble * (maxValue - minValue) + minValue;
return randomRangeDouble;
}

Console.Write("Введите количество элементов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
double[] myArray = new double [elements];

for (int i = 0; i < elements; i++)
{
    myArray[i] = Math.Round(RandomDouble(0, 10), 3);
    string thing = "; ";    
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

double result = DiffElArray(myArray);
Console.Write($"--> {result}");