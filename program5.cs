write a program to show the usage off this keyword
using System;
class Test {
    
    void display()
    {
        this.show();
        
        Console.WriteLine("Inside display function");
    }
    
    void show()
    {
        Console.WriteLine("Inside show function");
    }
    public static void Main(String []args)
    {
        Test t1 = new Test();
        t1.display();
    }
}
