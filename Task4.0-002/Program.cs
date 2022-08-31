void NumberOfDigits(int number)
{
    int count = 0;
    number = Math.Abs(number);
    while(number > 0)
    {
        number = number / 10;
        count++;
    }
    Console.WriteLine(count);
}
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

NumberOfDigits(a);
