// To show usage of THIS keyword
using System;

public class Person
{
    // Instance variables
    private string name;
    private int age;

    // Constructor to initialize the object
    public Person(string name, int age)
    {
        // 'this' is used to differentiate between the instance variables and parameters
        this.name = name;
        this.age = age;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }

    // Method to compare two persons (returns true if same age)
    public bool IsSameAge(Person otherPerson)
    {
        return this.age == otherPerson.age;
    }

    public static void Main(string[] args)
    {
        // Create two instances of Person
        Person person1 = new Person("John", 25);
        Person person2 = new Person("Alice", 25);

        // Display information
        person1.DisplayInfo();
        person2.DisplayInfo();

    }
}
