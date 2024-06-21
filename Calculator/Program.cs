// Simple Calculator with 5 operators -> +, -, *, / and "Power operator"

Console.WriteLine("Enter first number:");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter second number:");
string b = Console.ReadLine();
float num2 = float.Parse(b);

Console.WriteLine($"The Addition of {num1} and {num2} equals to {num1 + num2}");
Console.WriteLine($"The Subtraction of {num1} and {num2} equals to {num1 - num2}");
Console.WriteLine($"The Multiplication of {num1} and {num2} equals to {num1 * num2}");

if (num2 != 0)
    Console.WriteLine($"The Division of {num1} and {num2} equals to {num1 / num2}");
else
    Console.WriteLine("Error! You cannot delete to 0");

Console.WriteLine($"{num1} in {num2} power(s) equals to {Math.Pow(num1, num2)}");

// the note
float Addition = num1 + num2;
float Subtraction = num1 - num2;
float Multiplication = num1 * num2;
float Division = num1 / num2;
double PowerOfNumb = Math.Pow(num1, num2);