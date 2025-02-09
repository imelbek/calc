
// Simple Calculator 

Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
string b = Console.ReadLine();
double num2 = double.Parse(b);

// Formulas
double sum = num1 + num2;
double minus = num1 - num2;
double multipl = num1 * num2;
double divis = num1 / num2;
double positPercentage = num1 * num2 / 100;
double negatPercentage = num1 * (100 - Math.Abs(num2)) / 100;

// +
Console.WriteLine($"{num1} + {num2} = {sum}");

// -
Console.WriteLine($"{num1} - {num2} = {minus}");

// *
Console.WriteLine($"{num1} * {num2} = {multipl}");

// : or /
if (num2 == 0)
    Console.WriteLine("Error! You cannot delete to 0");
else 
    Console.WriteLine($"{num1} / {num2} = {divis}");    

// Remainer
if (num2 == 0)
    Console.WriteLine("Error! You cannot delete to 0 and get the remainer from division");
else
    Console.WriteLine($"The remainer from devision of {num1} and {num2}: {num1 % num2}");

// Power
if (num1 == 0 && num2 == 0)
    Console.WriteLine("0^0 doesn't have a value");
else
    Console.WriteLine($"{num1}^{num2} = {Math.Pow(num1, num2)}");

// Square root
if (num1 < 0 || num2 < 0)
    Console.WriteLine("Cannot have square root from negative number");
else
    Console.WriteLine($"v({num1}) is {Math.Sqrt(num1)} and v({num2}) is {Math.Sqrt(num2)}");

// % part
if (num2 >= 0) 
    Console.WriteLine($"{num1} * {num2}% = {positPercentage}");
else 
    Console.WriteLine($"{num1} * {num2}% = {negatPercentage}");

// the note
/*float Addition = num1 + num2;
float Subtraction = num1 - num2;
float Multiplication = num1 * num2;
float Division = num1 / num2;
double PowerOfNumb = Math.Pow(num1, num2);*/