﻿Console.WriteLine("Введите координаты точки по X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки по Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > d0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else
{
    Console.WriteLine("невозвожно определить координатную четверть точки");
}


