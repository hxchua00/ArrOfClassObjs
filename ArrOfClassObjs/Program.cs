using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create 2 classes, store 1 class object in the other class
namespace ArrOfClassObjs
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill newBill = new Bill();

            Item watermelon = new Item("Watermelon", 2.00, 10.2);
            Item chocolate = new Item("Chocolate", 15.00, 0.1);
            Item salmon = new Item("Salmon", 20.00, 5.6);
            Item watermelon1 = new Item("Watermelon", 2.00, 10.2);
            Item chocolate1 = new Item("Chocolate", 15.00, 0.1);
            Item salmon1 = new Item("Salmon", 20.00, 5.6);
            Item watermelon2 = new Item("Watermelon", 2.00, 10.2);
            Item chocolate2 = new Item("Chocolate", 15.00, 0.1);
            Item salmon2 = new Item("Salmon", 20.00, 5.6);
            Item watermelon3 = new Item("Watermelon3", 2.00, 10.2);
            Item chocolate3 = new Item("Chocolate3", 15.00, 0.1);
            //Item salmon = new Item("Salmon", 20.00, 5.6);

            newBill.AddItem(watermelon);
            newBill.AddItem(chocolate);
            newBill.AddItem(salmon);
            newBill.AddItem(watermelon1);
            newBill.AddItem(chocolate1);
            newBill.AddItem(salmon1);
            newBill.AddItem(watermelon2);
            newBill.AddItem(chocolate2);
            newBill.AddItem(salmon2);
            newBill.AddItem(watermelon3);
            newBill.AddItem(chocolate3);
            newBill.printAll();

            Console.ReadLine();
        }
    }
}
