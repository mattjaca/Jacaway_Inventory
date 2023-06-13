// Matthew Jacaway
// IT 112
// Notes: I struggled with the add method.
// Behaviors: None.

namespace Jacaway_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            while (true)
            {
                Console.WriteLine("Add an item?");
                Console.WriteLine("Select number for choices:");
                Console.WriteLine("1: Add a Bicycle to the shipment.");
                Console.WriteLine("2: Add a Lawn Mower to the shipment.");
                Console.WriteLine("3: Add a Baseball Glove to the shipment.");
                Console.WriteLine("4: Add Crackers to the shipment.");
                Console.WriteLine("5: List shipment items.");
                Console.WriteLine("6: Compute shipping charges.");
                Console.WriteLine("7: Exit.");

                string option = Console.ReadLine();
                Console.Clear();

                if (option == "1")
                {
                    Console.Clear();
                    shipper.Add(new Bicycle());
                    Console.WriteLine(shipper.AddedItem());
                }
                if (option == "2")
                {
                    Console.Clear();
                    shipper.Add(new LawnMower());
                    Console.WriteLine(shipper.AddedItem());
                }
                if (option == "3")
                {
                    Console.Clear();
                    shipper.Add(new BaseballGlove());
                    Console.WriteLine(shipper.AddedItem());
                }
                if (option == "4")
                {
                    Console.Clear();
                    shipper.Add(new Crackers());
                    Console.WriteLine(shipper.AddedItem());
                }
                if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine(shipper.ListItems());
                }
                if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine(shipper.ComputeShippingCharges().ToString("c"));
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
                if(option == "7")
                {
                    return;
                }
                if (shipper.Full == 10)
                {
                    Console.Clear();
                    Console.WriteLine("Your cart is full select from these options:");
                    do
                    {
                        Console.WriteLine("5: List shipment items.");
                        Console.WriteLine("6: Compute shipping charges.");
                        option = Console.ReadLine();
                        if(option == "5")
                        {
                            Console.Clear();
                            Console.WriteLine(shipper.ListItems());
                        }
                        if(option == "6")
                        {
                            Console.Clear();
                            Console.WriteLine(shipper.ComputeShippingCharges().ToString("c"));
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            return;
                        }
                    } while (shipper.Full == 10);
                }
            }
        }
    }
}



//For this assignment you will construct an inventory shipping application using a NET Core console application which will work similar to a website shopping cart.

//The application calculates shipping for four products:

//Bicycles(ship cost: $9.50)
//Lawn Mowers(ship cost: $24.00)
//Baseball Gloves(ship cost: $3.23)
//Crackers(ship cost: $.57)
//Each of these objects will be a base class which will implement the follow interface called IShippable.

//You will also create a shipping class named Shipper, entirely separate from the four products described. The shipping class will have an Add() method, which accepts an object of type IShippable.

//The Shipper object will accept up to 10 IShippable products, repeatedly asking to add a product or finish adding. This should be accomplished by having a menu-driven choice for the user:

//Choose from the following options:
//1.Add a Bicycle to the shipment
//2. Add a Lawn Mower to the Shipment
//3. Add a Baseball Glove to the shipment
//4. Add Crackers to the shipment
//5. List Shipment Items
//6. Compute Shipping Charges

//You can assume the shippable products will never exceed 10.

//The user will type a number and automatically have the item added, list all added items, or compute total cost. The Shipper object should confirm the item has been added:

//When "Compute Shipping Charges" is chosen, the Shipper object will return the total shipping cost of all added products, which will be displayed to the user. A message indicating  and pressing any key will terminate the program

//No shipping calculations, additional or alternate storage of shipping costs or any shipping calculation should be made until the Compute Shipping Charges is chosen. At that point, Shipper will calculate and output total shipping based on each added product's shipping costs.

//Test your math and rounding. Correct input is assumed for the assignment. Output of the result should be in well-formatted currency, such as: