// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int PosOrNeg (int[] arg)
{
   int sum = 0;
   for(int i = 0; i < arg.Length; i++)
   {
      if(arg[i] % 2 == 0)
      {
         sum++;
      }
   }
   return sum;
}

Console.Write("Введите количество элементов нового массива: ");
int elements = int.Parse(Console.ReadLine()!);
int[] myArray = new int [elements];
for(int i = 0; i < elements; i++)
{
   myArray[i] = new Random().Next(99, 1000);
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
int result = PosOrNeg(myArray);
Console.Write($"--> {result}");
