// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// int sum = 0;
// for(int b = 1; b <= a; b++)
// {
//    sum = sum + b;
// }
// Console.WriteLine(sum);

void GetSumNums(int n)
{
    int sum = 0;
    for(int b = 1; b <= n; b++)
    {
        sum += b;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

GetSumNums(a);