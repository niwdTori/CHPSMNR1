Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int number = num1 % num2;
if(number == 0) {Console.WriteLine("Кратно");}
else {Console.WriteLine($"Не кратно, остаток {number}");}

