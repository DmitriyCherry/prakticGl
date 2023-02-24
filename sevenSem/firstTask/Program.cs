// Задайте двумерный массив размером m*n, заполненный случайными числами.


double RandomDouble(double minValue, double maxValue)
{
var randomValue = new Random();
var randomDouble = randomValue.NextDouble();
double randomRangeDouble = randomDouble * (maxValue - minValue) + minValue;
return randomRangeDouble;
}

void PrintArray(double[,] arg, int height, int widht)
{
height = arg.GetLength(0);
widht = arg.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < widht; j++)
    {       
        arg[i,j] = Math.Round(RandomDouble(-4, 7), 2);;
        Console.Write(arg[i, j] + " ");
    }
    Console.WriteLine();
}
}

Console.WriteLine("Введите размерность массива: ");
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
double[,] myArray = new double [m,n];

PrintArray(myArray, m, n);

   
