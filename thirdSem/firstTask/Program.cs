/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/


Console.Write("Введите случайное пятизначное число: ");
int randomNum = int.Parse(Console.ReadLine()!);
int firstHalf = randomNum / 1000;
int secondHalf = randomNum % 100;

int firstHalf1 = firstHalf / 10;
int firstHalf2 = firstHalf % 10;
int secondHalf1 = secondHalf / 10;
int secondHalf2 = secondHalf % 10;

if (firstHalf1 == secondHalf2 && firstHalf2 == secondHalf1)
{
    Console.WriteLine("Да");
}else
{
    Console.WriteLine("Нет");
}
