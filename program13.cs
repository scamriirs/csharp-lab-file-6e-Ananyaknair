WAP to show the concept of method overriding


using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.Sound(); 

        Dog myDog = new Dog();
        myDog.Sound(); 
        
        Animal myAnimalDog = new Dog();
        myAnimalDog.Sound(); 
    }
}
