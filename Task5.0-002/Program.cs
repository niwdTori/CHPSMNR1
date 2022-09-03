// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     for (int index = 0; index < length; index++)
//     {
//         collection[index] = new Random().Next(-9,10);
//     }
// }

// int[] array = new int[12];

// FillArray(array);

// string concat = string.Join(",", array);
// Console.WriteLine(concat);

// int sumPos = 0;
// int sumNeg = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         sumPos += array[i];
//     }
//     else
//     {
//         sumNeg += array[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел равна: {sumPos}, сумма отрицательных чисел равна: {sumNeg}");

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
string concat = string.Join(",", array);
Console.WriteLine(concat);

int sumNeg = 0;
int sumPos = 0;
foreach (int el in array) //Для каждого элемента массива делай это
{
    sumNeg += el < 0 ? el : 0; //Фернарный условный оператор (принимает в себя 3 параметра)
    sumPos += el > 0 ? el : 0;
}
Console.WriteLine($"Сумма положительных чисел равна: {sumPos}, сумма отрицательных чисел равна: {sumNeg}");