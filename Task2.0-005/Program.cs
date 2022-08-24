Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе чило: ");
int num2 = int.Parse(Console.ReadLine());

int max = num2;
int min = num1;

if (num1 > num2)
{
    max = num1;
    min = num2;
}

if( min * min == max) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
