//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] arg)
{
int height = arg.GetLength(0);
int widht = arg.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < widht; j++)
    {
        arg[i,j] = new Random().Next(0, 10);
        Console.Write(arg[i, j] + " ");
    }
    Console.WriteLine();
}
}

void AverageColomns (int[,] arg1, int rows, int colomns)
{
    double currentResult = 0;              
    double result = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < colomns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            currentResult += arg1[j, i];
            result = Math.Round((currentResult / rows), 3);
        }
        if (i == colomns - 1) Console.Write(result + " ");
        else Console.Write(result + "; ");
        currentResult = 0;
        result = 0;
    } 
}

Console.Write("Введите количество строк: ");
int height = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int widht = int.Parse(Console.ReadLine()!);
int[,] myArray = new int [height, widht];
PrintArray(myArray);

AverageColomns(myArray, height, widht);


