/* Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53 ()*/
Random rand = new Random();
int x1 = rand.Next(0, 10);
int x2 = rand.Next(0, 10);
int x3 = rand.Next(0, 10);
int y1 = rand.Next(0, 10);
int y2 = rand.Next(0, 10);
int y3 = rand.Next(0, 10);
Console.WriteLine($" A ({x1},{x2},{x3}); B ({y1},{y2},{y3}) ");
Console.WriteLine(Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2)));