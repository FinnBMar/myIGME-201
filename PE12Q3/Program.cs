using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3 //Finn Marable Q3 PE 12 override method example
{
    public class MyClass
    {
        private string myString; //property with only a setter
        public string MyString
        {
            set
            {
                this.myString = value;
            }
        }
        public virtual string GetString() //GetString method that works just like a getter

        {
            return this.myString;
        }
    }

    public class MyDerivedClass : MyClass    //child class that overrides the GetString() method
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass(); //create instance of the myDerivedClass
            Console.WriteLine(myDerivedClass.GetString());
        }
    }


}