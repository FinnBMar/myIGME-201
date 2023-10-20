using System;

public interface IMyInterface //Finn Marable PE 14 This program calls myMethod for each object using the interface to ensure correct implementation.
{
    void MyMethod();
}
public class CustomClassA : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("CustomClassA implementation.");
    }
}
public class CustomClassB : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("CustomClassB implementation.");
    }
}
class Program
{
    public static void Main()
    {
        IMyInterface objectA = new CustomClassA();
        IMyInterface objectB = new CustomClassB();

        CallMyMethod(objectA);
        CallMyMethod(objectB);
    }
    public static void CallMyMethod(object myObject)
    {
        if (myObject is IMyInterface)
        {
            ((IMyInterface)myObject).MyMethod();
        }
        else
        {
            Console.WriteLine("Object does not implement IMyInterface.");
        }
    }
}

