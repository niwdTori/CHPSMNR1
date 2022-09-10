int[,] GetArray(int m, int n, int minValue, int maxValue) // Заполение двумерного массива
{
    int[,] res = new int[m,n];
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
    {
        res[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    }
    return res;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 10);
PrintArray(result);