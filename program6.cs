write a program to find the square of a number
using pass by value , using pass by reference


using System;

class SquareCalculator
{
    public static int SquareByValue(int number)
    {
        return number * number;
    }

    public static void SquareByReference(ref int number)
    {
        number = number * number;
    }

    static void Main(string[] args)
    {
        int value = 8;
        int resultByValue = SquareByValue(value);
        Console.WriteLine("Square using pass by value: " + resultByValue);

        int valueByReference = 8;
        SquareByReference(ref valueByReference);
        Console.WriteLine("Square using pass by reference: " + valueByReference);
    }
}
