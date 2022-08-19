Console.WriteLine("Hello! Is the first number the square of the second?");

Console.WriteLine("Please, input first number: ");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please, input second number: ");
int SecondNumber = int.Parse(Console.ReadLine());

if(SecondNumber * SecondNumber == FirstNumber) 
{
    Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No:(");
}