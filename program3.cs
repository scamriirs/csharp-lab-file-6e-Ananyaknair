write a program to find the integer and fractional part of a number using out keyword

using System;

class Program
{
    static void GetFractionalPart(double number, out double fractionalPart)
    {
        fractionalPart = number - Math.Floor(number);
    }

    static void Main()
    {
        double number = 5.75;
        double fractionalPart;

        GetFractionalPart(number, out fractionalPart);

        Console.WriteLine($"The fractional part of {number} is {fractionalPart}");
    }
}
