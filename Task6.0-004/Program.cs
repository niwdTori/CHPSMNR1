// Первые N чисел фибоначчи

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int num1 = 0;
int num2 = 1;
Console.Write("01");
for ( int i = 0; i < n-2; i++)
{
    int num = num1 + num2;
    num1 = num2;
    num2 = num;
    Console.Write(num);
}