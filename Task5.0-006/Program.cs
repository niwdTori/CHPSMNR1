int size = 3;
int minValue = 1;
int maxValue = 10;
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}

Console.WriteLine(string.Join(",", array));

int SizeMas(int size)
{
    int sizeMas = 0;
    int x = size%2;
    if(x==0)
    {
        sizeMas = size/2;
    }
    else
    {
        sizeMas = size/2+1;
    }
    return sizeMas;
}

int j = array.Length - 1;
int[] mas = new int[SizeMas(size)];
int a = 0;
int count = 0;
for(int i = 0; i < j; i++)
{
    mas[a] = array[i] * array[j];
    j--;
    a++;
    count++;

}
if(SizeMas(size)!= count)
{
    mas[a] = array[a];
}

Console.WriteLine(string.Join(",", mas));