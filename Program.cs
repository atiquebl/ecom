using System;

class Program
{
    static void Main(string[] args)
    {
        IScientificCalculator calculator = new ScientificCalculator();

        Console.WriteLine("=== Basic & Scientific Calculator ===");

        
        Console.WriteLine( calculator.Add(5, 10));
        Console.WriteLine(calculator.Subtract(7, 2));
        Console.WriteLine(calculator.Multiply(5, 6));
        Console.WriteLine(calculator.Divide(10, 3));
        Console.WriteLine(calculator.SquareRoot(4));
        Console.WriteLine(calculator.Power(2,3));


    }
   }



