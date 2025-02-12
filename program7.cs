create a program to show the concept of method overloading
using System;

class OverloadExample 
{
    void Show(int a) => Console.WriteLine("Integer: " + a);
    void Show(double a) => Console.WriteLine("Double: " + a);
    void Show(string a) => Console.WriteLine("String: " + a);

    static void Main() 
    {
        OverloadExample obj = new OverloadExample();
        obj.Show(10);
        obj.Show(10.5);
        obj.Show("Hello");
    }
}
