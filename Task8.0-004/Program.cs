// Удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

// Создание двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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
int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);
Console.WriteLine();

// нахождение минимального элемента
int elmin = array[0, 0];
int minrow = 0;
int mincolumn = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (elmin > array[i, j])
        {
            elmin = array[i, j];
            minrow = i;
            mincolumn = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент: {elmin}");

// удаление строки и столбца
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     if (i == minrow) i++;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (j != mincolumn) Console.Write($"{array[i, j]} ");
//         else
//         {
//             j++;
//             Console.Write($"{array[i, j]} ");
//         }
//         // if(i == minrow || j == mincolumn) continue;
//         // Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }

int[,] GetArrayNew(int[,] arr, int minrw, int minclmn)
{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int n = 0;
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != minclmn && i != minrw)
            {
                res[n, m] = arr[i, j];
                m++;
            }
        }
        m = 0;
        if (minrw != i) n++;
    }
    return res;
}

int[,] arrayNew = GetArrayNew(array, minrow, mincolumn);
PrintArray(arrayNew);