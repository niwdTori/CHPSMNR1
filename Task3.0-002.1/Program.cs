Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

switch(number)
{
    case 1:
    {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0, y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0, y < 0");
        break;
    }

    default:
    {
        Console.WriteLine("Введено неправильное значение для четверти");
        break;
    }
}