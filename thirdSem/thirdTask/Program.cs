/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write(count);
for (int i = count +1; i <= numN; i++)
{
    int result = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($", {result}");
}