//Количество элементов массив, значения которых лужат в определённом отрезке

int size = 123;
int minValue = 1;
int maxValue = 124;
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}

Console.WriteLine(string.Join(",", array));

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}

Console.WriteLine(count);