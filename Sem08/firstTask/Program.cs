/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4    В итоге получается вот такой массив:
                         7 4 2 1
                         9 5 3 2
                         8 4 4 2*/

void PrintArray(int[,] arg)
{
int height = arg.GetLength(0);
int widht = arg.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < widht; j++)
    {         
        arg[i, j] = new Random().Next(-4, 10);
        Console.Write(arg[i, j] + " ");
    }
    Console.WriteLine();
}
}

void ArrayFromMax (int[,] arr)
{    
    int temp = 0;    
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        int[] mass = new int [arg.GetLength(1)]; 
        for (int j = 0; j < arg.GetLength(1); j++)
        {       
            for (int k = j + 1; k < arg.GetLength(1); k++)
            {              
                if (arg[i,j] < arg[i,k])
                {                
                    temp = arg[i,j];
                    arg[i,j] = arg[i,k];
                    arg[i,k] = temp;
                }          
            }     
        }
        for (int j = 0; j < arg.GetLength(1); j++)
        {               
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
int[,] myArray = new int [m,n];
PrintArray(myArray);
Console.WriteLine();
ArrayFromMax(myArray);

