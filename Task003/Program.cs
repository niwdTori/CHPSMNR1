Console.WriteLine("Hello! All integers from -N to N");
Console.WriteLine("Please, input number: ");
int numberA = int.Parse(Console.ReadLine());

for (int numberB = (-numberA); numberB <= numberA; numberB++)
    Console.Write(numberB + " ");
