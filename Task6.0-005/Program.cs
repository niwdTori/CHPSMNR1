// Копия заданого массива
int[] array = { 1, 3, 4, 8, 1, 8 };
int[] massiv = new int[array.Length];

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    massiv[j] = array[i];
    j++;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);
Console.WriteLine();
PrintArray(massiv);