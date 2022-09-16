// Частотный словарь элементов массива

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
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

// Двумерный массив в одномерный
int[] NewArray(int[,] mas)
{
    int[] masNew = new int[mas.GetLength(0) * mas.GetLength(1)];
    int k = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            masNew[k] = mas[i, j];
            k++;
        }
    }
    return masNew;
}
int[] arrayNew = new int[rows * columns];
arrayNew = NewArray(array);
void PrintNewArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintNewArray(arrayNew);
Console.WriteLine();

//Сортировка массива
int[] SortingArray(int[] mas)
{
    int size = mas.Length;
    while (size > 0)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (mas[i] > mas[i + 1])
            {
                int temp = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = temp;
            }
        }
        size = size - 1;
    }
    return mas;
}
arrayNew = SortingArray(arrayNew);
PrintNewArray(arrayNew);
Console.WriteLine();

//

int el = arrayNew[0];
int count = 1;
for (int i = 1; i < arrayNew.Length; i++)
{
    if (el != arrayNew[i])
    {
        Console.WriteLine($"{el} встречается {count} раз");
        el = arrayNew[i];
        count = 1;
    }
    else count++;
    if(i == arrayNew.Length-1) Console.WriteLine($"{el} встречается {count} раз");
}


