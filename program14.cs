write a program to show the concept of indexer
using System;

class MyCollection
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < arr.Length)
                return arr[index];
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
        set
        {
            if (index >= 0 && index < arr.Length)
                arr[index] = value;
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
    }
}

class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection();
        collection[0] = 10;
        collection[1] = 20;

        Console.WriteLine(collection[0]);
        Console.WriteLine(collection[1]);
    }
}
