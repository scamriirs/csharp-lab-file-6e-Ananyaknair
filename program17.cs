write a program to show the concept of overriding


using System;
public interface IAnimal
{
    void Speak();
}
public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}


public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();

        animal1.Speak();
        animal2.Speak();
    }
}
