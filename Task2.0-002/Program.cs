int number = new Random().Next(100, 1000);
int a1 = number / 100 * 10;
int a3 = number % 10;

int num = a1 + a3;

Console.WriteLine($"a1: {a1} , a3: {a3}");
Console.WriteLine($"Число: {number} -> {num}");