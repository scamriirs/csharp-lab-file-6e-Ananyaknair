write a program to show the concept of indexer

using System;

class MyCollection
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
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
