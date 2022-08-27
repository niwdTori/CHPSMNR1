//void VivestiChetvert(int chetvert) 
// {
//     Console.WriteLine($"Точка принадлежит {chetvert}");
// }

Console.WriteLine("Пожалуйста, введите х: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) { Console.WriteLine("Точка находится в 1 четверти"); }
if (x > 0 && y < 0) { Console.WriteLine("Точка находится в 4 четверти"); }
if (x < 0 && y > 0) { Console.WriteLine("Точка находится в 2 четверти"); }
if (x < 0 && y < 0) { Console.WriteLine("Точка находится в 3 четверти"); }