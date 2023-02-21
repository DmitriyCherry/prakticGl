// Задайте двумерный массив размером m*n, заполненный случайными числами.



double RandomDouble(double minValue, double maxValue)
{
var randomValue = new Random();
var randomDouble = randomValue.NextDouble();
double randomRangeDouble = randomDouble * (maxValue - minValue) + minValue;
return randomRangeDouble;
}

Console.WriteLine("Введите размерность массива: ");
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
double [,] myArray = new double [m,n];
m = myArray.GetLength(0);
n = myArray.GetLength(1);

for (int y = 0; y < m; y++)
{
    for (int x = 0; x < n; x++)
    {
        myArray[y,x] = Math.Round(RandomDouble(-4, 7), 2);
        Console.Write(myArray[y,x] + " ");
    }
    Console.WriteLine();
}    
