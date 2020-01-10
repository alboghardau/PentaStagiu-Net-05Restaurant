using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLibrary;

namespace Tema05
{
    class Program
    {
        private static Restaurant restaurant = new Restaurant();
        static void Main(string[] args)
        {
            AddSomeItemsToMenu();

            Console.WriteLine("Application commands:");
            Console.WriteLine("add - add item | delete - delete one item by id | list - display menu | find - display one item by id ; exit - exit app\n");
            Console.WriteLine("################################################\n");
            
            while (true)
            {
                Console.Write("COMMAND:");

                String command = Console.ReadLine();

                switch (command)
                {
                    case "delete":
                        DeleteItem();
                        break;
                    case "list":
                        DisplayItems();
                        break;
                    case "exit":
                        return;
                    default: 
                        Console.WriteLine("Command not found!");
                        break;
                }
                Console.WriteLine("");
            }
        }

        static void AddItem()
        {
            
        }

        static void DeleteItem()
        {
            Console.Write("ID:");
            try
            {
                int id = int.Parse(Console.ReadLine());
                restaurant.RemoveItem(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input!");
            }
        }

        //finds an item and prints to screen
        static void FindItem()
        {
            Console.Write("ID:");
            try
            {

            }catch(Exception e)
            {

            }
        }

        //prints all items to screen
        static void DisplayItems()
        {
            List<MenuItem> list = restaurant.GetAllItems();

            Console.WriteLine("############################\n");
            foreach (MenuItem item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n############################\n");
        }

        //function to add some items at start of program
        static void AddSomeItemsToMenu()
        {
            ChickenBurger a = new ChickenBurger();
            a.Name = "American Burger";
            a.Price = 25;
            a.HasPickle = true;
            a.Calories = 550;
            restaurant.AddItem(a);

            HotDrink d = new HotDrink();
            d.Name = "Capuccino";
            d.Price = 10;
            d.Volume = 250;
            d.HasCaffeine = true;
            restaurant.AddItem(d);
        }
    }
}
