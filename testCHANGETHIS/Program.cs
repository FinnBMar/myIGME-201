using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyClass
{
    public int SomeField { get; set; }
    public MyClass() { }
    public MyClass(MyClass source)
    {
        SomeField = source.SomeField;
    }
    public static void Main(string[] args)
    {
        MyClass objectA = new MyClass();
        MyClass objectB = new MyClass(objectA);
    }
}