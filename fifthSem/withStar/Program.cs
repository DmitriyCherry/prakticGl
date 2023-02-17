// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]


void BubbleSort (int[] arg)
{    
    int temp;
    
    for (int i = 0; i < arg.Length - 1; i++)
    {
        if (arg[i] < arg[i+1])
        {
            temp = arg[i+1];
            arg[i+1] = arg[i];
            arg[i] = temp;
        }                
        
        for (int j = 0; j < arg.Length - 1; j++)
        {
            if (arg[j] < arg[j+1])
            {
                temp = arg[j+1];
                arg[j+1] = arg[j];
                arg[j] = temp;
            }
        }
    
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

Console.Write("Введите количество элементов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
int[] myArray = new int [elements];
Console.Write("Сгенерированный массив --> ");
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
Console.WriteLine();
Console.Write("Отсортированный массив --> ");
BubbleSort(myArray);