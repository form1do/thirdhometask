//Нахождение расстояния между точками в 3D
Console.WriteLine("Введите координаты x первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
System.Console.WriteLine($"{result} - искомое расстояние");