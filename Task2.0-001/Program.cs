int number = new Random().Next(10, 100);
int a1 = number/ 10;
int a2 = number % 10;

int max = a1;
if (max < a2){ max = a2;}

Console.WriteLine($"В числе {number} максимальная цифра: {max}");
