//Произведение чисел от 1 до N

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

void MultiplicationfNumbers(int number)
{
    int sum = 1;
    for(int n = 2; n <= number; n++)
    {
        sum = sum * n;
    }
    Console.WriteLine($"Произведение равно: {sum}");
}

MultiplicationfNumbers(a);