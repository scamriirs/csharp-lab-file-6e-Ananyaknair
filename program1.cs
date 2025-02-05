//Create a program to show the usage of parameterized constructor , parameterless and default
using System;

class Person
{
    // Parameterless constructor
    public Person()
    {
        Name = "Ananya";
        Age = 20;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // parameterless constructor
        Person person1 = new Person();
        person1.DisplayInfo();

        // parameterized constructor
        Person person2 = new Person("John", 30);
        person2.DisplayInfo();
    }
}
