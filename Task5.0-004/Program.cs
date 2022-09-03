int size = 5;
int minValue = -100;
int maxValue = 100;
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
string concat = string.Join(",", array);
Console.WriteLine(concat);

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool exists = false;

for (int i = 0; i < array.Length; i++)
{
   if(array[i] == number)
   {
    exists = true;
    break;
   }
}

if(exists)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
