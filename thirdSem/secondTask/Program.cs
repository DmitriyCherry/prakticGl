/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.WriteLine("Введите координаты для точки A: ");
Console.Write("Координата точки A по оси OX: ");
double ax =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки A по оси OY: ");
double ay =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки A по оси OZ: ");
double az =  double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты для точки B: ");
Console.Write("Координата точки B по оси абсцисс: ");
double bx =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки B по оси ординат: ");
double by =  double.Parse(Console.ReadLine()!);
Console.Write("Координата точки A по оси OZ: ");
double bz =  double.Parse(Console.ReadLine()!);

double bc = Math.Pow(ax-bx, 2);
double ac = Math.Pow(ay-by, 2);
double zc = Math.Pow(az-bz, 2);
double result = Math.Sqrt(bc + ac + zc);
double roundResult = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками будет равно: {roundResult}");