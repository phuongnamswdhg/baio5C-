using System;
using Order;


class Cust_details
{
    public string strName;
    public void getName()
    {
        Console.WriteLine("Enter your name  :");
        strName = Console.ReadLine();
    }
}


namespace Order
{
    class Grocery_itema
    {
        public void Ord_grocery()
        {
            Cust_details objCust1 = new Cust_details();
            objCust1.getName();
            Console.WriteLine("Hello {0}", objCust1.strName);
            Console.WriteLine("You have ordered grocery items");
        }
    }
    class Bakeyry_items
    {
        public void Ord_bakery()
        {
            Cust_details objCust2 = new Cust_details();
            objCust2.getName();
            Console.WriteLine("Hello {0}", objCust2.strName);
            Console.WriteLine("You have ordered grocery items");
        }
    }

}
class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("What would you like to order? 1-Grocery Items.2-Bakery Items");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Grocery_itema objGrocery = new Grocery_itema();
            objGrocery.Ord_grocery();

        }

        else
        {
            if (choice == "2")
            {
                Bakeyry_items objBakeyry = new Bakeyry_items();
                objBakeyry.Ord_bakery();

            }
            else
            {
                Console.WriteLine("Enter either 1 or 2");
            }
        }
        Console.ReadLine();
    }
}