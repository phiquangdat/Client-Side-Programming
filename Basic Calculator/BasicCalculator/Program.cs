using System;

class Program
{
  static void Main()
  {
    var calc = new Calculator();

    Console.WriteLine("Enter an expression (e.g: 1 + 2): ");
    string[] parts = Console.ReadLine().Split(' ');

    double a = double.Parse(parts[0]);
    string op = parts[1];
    double b = double.Parse(parts[2]);

    double result = op switch
    {
      "+" => calc.Add(a, b),
      "-" => calc.Subtract(a, b),
      "*" => calc.Multiply(a, b),
      "/" => b != 0 ? calc.Divide(a, b) : throw new DivideByZeroException(),
      _ => throw new InvalidOperationException("Invalid operator")
    };

    Console.WriteLine($"Result: {result}");
  }
}
