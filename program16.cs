using System;

class MyCollection
{
    private int[] arr = new int[5];
    private string[] names = new string[5];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    public string this[string name]
    {
        get
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return $"Found: {names[i]} at index {i}";
            }
            return "Not found";
        }
        set
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    names[i] = value;
                    return;
                }
            }
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

        collection["John"] = "Developer";
        Console.WriteLine(collection["John"]);
    }
}
