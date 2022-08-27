Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

double A = Math.Pow((x2 - x1), 2);
double B = Math.Pow((y2 - y1), 2);


double AB = Math.Sqrt(A + B);

Console.WriteLine($"Расстояние равно: {AB}");