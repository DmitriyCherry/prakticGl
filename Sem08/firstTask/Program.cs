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
        Console.Write(arg[i, j] + " ");
    }
    Console.WriteLine();
}
}

void RevMinOrMax (int[,] arg)
{    
for (int i = 0; i < arg.GetLength(0); i++)
    {     
        
        for (int j = 0; j < arg.GetLength(1); j++)
        {                
          int max = arg[0,0];
            if (arg[i,j] > max)
            {
                int temp = max;
                max = arg[i,j];
             }            
            
                arg[i,j] = temp; 
        }
   }
}

int[,] myArray = new int [,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}  
};

RevMinOrMax(myArray);
PrintArray(myArray);