// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void MyArray (int[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
        string thing = ", ";
        array[i] = new Random().Next(0, 100);
        if (i == array.Length - 1)
        {
            thing = "";
        }
        Console.Write(array[i] + thing);
    }
}

Console.Write("Введите количество элементов в новом массиве: ");
int elements = int.Parse(Console.ReadLine()!);
int[] newArray = new int [elements];
MyArray(newArray); 