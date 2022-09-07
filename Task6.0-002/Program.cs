Console.WriteLine("Введите сторону a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону c: ");
double c = double.Parse(Console.ReadLine());

if( a + b > c && b+c > a && a+c > b) Console.WriteLine("Да");
else Console.WriteLine("Нет");