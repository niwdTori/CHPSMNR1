int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;

string concat = string.Join(",", arr);
//Выводит элементы массива через запятую
string MyJoin(string delimiter, int[] array)
{
    string result = ""; //создание пустой строки
    for(int i = 0; i < array.Length - 1; i++)
    {
        result = result + array[i] + delimeter;
    }
    result = result + array[array.Length - 1];

    return result;
}

string joinedArray = MyJoin(",", arr);
Console.WriteLine(joinedArray);