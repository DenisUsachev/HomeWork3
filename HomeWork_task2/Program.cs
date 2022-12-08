/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());


int X = x2 - x1;
int Y = y2 - y1;
int Z = z1 - z2;

double length = Math.Sqrt(X * X + Y * Y + Z * Z);

Console.WriteLine($"Расстояние между точками = {length}");
