Console.WriteLine("Hello! Is the first number the square of the second?");

Console.WriteLine("Please, input first number: ");
string FNumber = Console.ReadLine();
int FirstNumber = int.Parse(FNumber);

Console.WriteLine("Please, input second number: ");
string SNumber = Console.ReadLine();
int SecondNumber = int.Parse(SNumber);

if(SecondNumber * SecondNumber == FirstNumber) 
{
    Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No:(");
}