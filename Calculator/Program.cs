// Simple Calculator with 5 operators -> +, -, *, / and "Power operator"

Console.Write("Enter first number: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
string b = Console.ReadLine();
float num2 = float.Parse(b);

float sum = num1 + num2;
float minus = num1 - num2;
float multipl = num1 * num2;
float divis = num1 / num2;

Console.WriteLine($"The Addition: {num1} + {num2} = {sum}");
Console.WriteLine($"The Subtraction: {num1} - {num2} = {minus}");
Console.WriteLine($"The Multiplication: {num1} * {num2} = {multipl}");

if (num2 != 0)
    Console.WriteLine($"The Division: {num1} / {num2} = {divis}");
else
    Console.WriteLine("Error! You cannot delete to 0");

Console.WriteLine($"The remainer from devision: {num1 % num2}");
Console.WriteLine($"{num1}^{num2} = {Math.Pow(num1, num2)}");
Console.WriteLine($"The square root of ({num1}) is {Math.Sqrt(num1)} and the square root of ({num2}) is {Math.Sqrt(num2)}");

// the note
/*float Addition = num1 + num2;
float Subtraction = num1 - num2;
float Multiplication = num1 * num2;
float Division = num1 / num2;
double PowerOfNumb = Math.Pow(num1, num2);*/