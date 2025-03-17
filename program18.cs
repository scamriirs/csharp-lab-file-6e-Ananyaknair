write a program to show the concept of overloading 

using System;

public class Calculator
{
    
    public int Add(int a, int b)
    {
        return a + b;
    }

    
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Calling different overloaded methods
        Console.WriteLine(calc.Add(2, 3));          // Output: 5
        Console.WriteLine(calc.Add(2, 3, 4));       // Output: 9
        Console.WriteLine(calc.Add(2.5, 3.5));      // Output: 6.0
    }
}
