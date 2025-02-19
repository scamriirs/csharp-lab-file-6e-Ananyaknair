write a program to implement the concept of interface

  using System;
interface Bank
{
    public void roi();
}
class ICICI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 7%");
    }
}
class HDFC : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 6.5%");
    }
}
class SBI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 6%");
    }
}
class Test
{
    public static void Main()
    {
        Bank b;
    b = new ICICI();
    b.roi();
    b = new HDFC();
    b.roi();
    b = new SBI();
    b.roi();
    }
}
