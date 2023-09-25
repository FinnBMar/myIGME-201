using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Q4_Marable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order newItem;
            newItem.itemName = "wheaties";
            newItem.unitCount = 5;
            newItem.unitCost = 10;
            Console.WriteLine(newItem.orderInfo());
        }

        struct Order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

           
            public double totalPrice ()
            {
                return (unitCount * unitCost);
            }

            public string orderInfo()
            {
                return ("Order Information: " + unitCount + " " + itemName + " items at $" + unitCost + " each, total cost $" + totalPrice());
            }
        }

    }
}
