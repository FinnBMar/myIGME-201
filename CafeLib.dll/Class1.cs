using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib //Finn Marable IGME 201 CafeLib PE 16
{
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }
    public class Waiter : IMood
    {
        //fields
        public string name;

        //methods
        public string Mood
        {
            get;
        }
        public void ServeCustomer(HotDrink cup)
        {
            Console.WriteLine("Here's your drink");
        }
    }
    public class Customer : IMood
    {
        public string name; //fields
        public string creditCardNumber;
        public string Mood //methods
        {
            get;
        }
    }
    public abstract class HotDrink
    {
        public bool instant; //fields 
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;
        public virtual void AddSugar(byte amount) //methods
        {
            this.sugar += amount;
        }
        public abstract void Steam();
        public HotDrink() //constructors
        {
        }
        public HotDrink(string brand)
        {
        }
    }
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType; //fields
        public override void Steam() //methods
        {
            Console.WriteLine("Steaming the coffee!");
        }
        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        }
        public CupOfCoffee(string brand) : base(brand)
        {
            this.beanType = brand;
        }
    }
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType; //fields
        public override void Steam() //methods
        {
            Console.WriteLine("Steaming the coffee!");
        }
        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        }
        public CupOfTea(bool customerIsWealthy) //constructors
        {
            if (customerIsWealthy)
            {
                this.leafType = "fancy";
            }
        }
    }
    public interface ITakeOrder
    {
        void TakeOrder();
    }
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups = 0; //fields
        public bool marshmallows;
        private string source;
        public string Source //methods
        {
            set
            {
                this.source = value;
            }
        }
        public override void Steam()
        {
            Console.WriteLine("Steaming the coffee!");
        }
        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }
        public void TakeOrder()
        {
            Console.WriteLine("What would you like?");
            string order = Console.ReadLine();
            Console.WriteLine("One " + order + " coming up!");
        } 
        public CupOfCocoa() : this(false) //constructors
        {
            numCups++;
        }
        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            this.marshmallows = marshmallows;
        }
    }

}