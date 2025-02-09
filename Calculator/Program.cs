// Simple Calculator with 5 operators -> +, -, *, /, % and "Power operator"

Console.Write("Enter first number: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
string b = Console.ReadLine();
float num2 = float.Parse(b);

float sum = num1 + num2;
float minus = num1 - num2;
float multipl = num1 * num2;
float divis = num1 / num2;
float positPercentage = num1 * num2 / 100;
float negatPercentage = num1 * (100 - Math.Abs(num2)) / 100;

Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} - {num2} = {minus}");
Console.WriteLine($"{num1} * {num2} = {multipl}");

if (num2 != 0)
    Console.WriteLine($"{num1} / {num2} = {divis}");
else
    Console.WriteLine("Error! You cannot delete to 0");

Console.WriteLine($"The remainer from devision: {num1 % num2}");
Console.WriteLine($"{num1}^{num2} = {Math.Pow(num1, num2)}");
Console.WriteLine($"v({num1}) is {Math.Sqrt(num1)} and " +
    $"v({num2}) is {Math.Sqrt(num2)}");

if (num2 >= 0) Console.WriteLine($"{num1} * {num2}% = {positPercentage}");
else Console.WriteLine($"{num1} * {num2}% = {negatPercentage}");

// the note
/*float Addition = num1 + num2;
float Subtraction = num1 - num2;
float Multiplication = num1 * num2;
float Division = num1 / num2;
double PowerOfNumb = Math.Pow(num1, num2);*/