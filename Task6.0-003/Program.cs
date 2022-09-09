// Преобразовать десятичное число в двоичное

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = 0;
string b = "";

while(number >= 1)
{
    a = number%2;
    b = a + b;
    number = number/2;
}

Console.WriteLine(b);