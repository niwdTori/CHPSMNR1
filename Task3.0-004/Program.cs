Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int b = 1;

while(b <= a)
{
    double c = Math.Pow(b, 2);
    Console.Write(c + ", ");
    b++;
}