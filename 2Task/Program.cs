// Точки в 3D пространстве
Console.WriteLine("Введите координаты двух точек");
Console.Write("x1?: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1?: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1?: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2?: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2?: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2?: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine("Расстояние между точками равно: " + L);