void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}    


int[] array = new int[4];
FillArray(array);
PrintArray(array);

int j = array.Length - 1;
for(int i = 0; i < j; i++) // i < array.Length - 1
{
    int temparray = array[i];
    array[i] = array[j];  // = array[array.Length - i - 1]
    array[j] = temparray; // array[array.Length - i - 1] =
    j--;
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
