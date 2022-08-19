Console.WriteLine("Hello! Enter the number and find out the day of the week;)");

Console.WriteLine("Please, input number day: ");
int numberday = int.Parse(Console.ReadLine());

if(numberday == 1) {Console.WriteLine("Monday");}
if(numberday == 2) {Console.WriteLine("Tuesday");}
if(numberday == 3) {Console.WriteLine("Wednesday");}
if(numberday == 4) {Console.WriteLine("Thursday");}
if(numberday == 5) {Console.WriteLine("Friday");}
if(numberday == 6) {Console.WriteLine("Saturday");}
if(numberday == 7) {Console.WriteLine("Sunday");}
if(numberday > 7) {Console.WriteLine("There are only 7 days in a week;)");}



