 Console.WriteLine("Пожалуйста, введите номер четверти: ");
 int number = int.Parse(Console.ReadLine());

while(number < 0 || number > 4) 
{
    Console.WriteLine("Пожалуйста, введите номер четверти: ");
    number = int.Parse(Console.ReadLine());
}

if(number == 1) {Console.WriteLine("Диапазон возможных координат: x > 0, y > 0");}
if(number == 2) {Console.WriteLine("Диапазон возможных координат: x < 0, y > 0");}
if(number == 3) {Console.WriteLine("Диапазон возможных координат: x < 0, y < 0");}
if(number == 4) {Console.WriteLine("Диапазон возможных координат: x > 0, y < 0");}
