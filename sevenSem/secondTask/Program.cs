// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение того элемента или же указание, что такого элемента нет.

void SearchEl(int[,] arg, int oxEl, int oyEl)
{    
    oxEl -= 1; oyEl -= 1; 
    int result = 0;
    string exeption = "--> Такого элемента нет";
    
    if (oxEl < arg.GetLength(0) && oyEl < arg.GetLength(1))
        {
            result = arg[oxEl, oyEl];
            Console.WriteLine($"--> {result} ");
        }
        else
            {
                Console.WriteLine(exeption);
            }       
       
}

Console.Write("Введите количество строк: ");
int height = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int widht = int.Parse(Console.ReadLine()!);
int[,] myArray = new int [height, widht];
height = myArray.GetLength(0);
widht = myArray.GetLength(1);

Console.Write("Введите координату элемента по X: ");
int oxCount = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату элемента по Y: ");
int oyCount = int.Parse(Console.ReadLine()!);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < widht; j++)
    {
        myArray[i, j] = new Random().Next(0, 10);
        Console.Write(myArray[i, j] + " ");              
         
    } 
    Console.WriteLine();   
}

SearchEl(myArray, oxCount, oyCount);