void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0,2);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]}, ");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);