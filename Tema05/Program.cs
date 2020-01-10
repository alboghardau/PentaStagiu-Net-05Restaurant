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
                    case "add":
                        AddItem();
                        break;
                    case "delete":
                        DeleteItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "list":
                        DisplayItems();
                        break;
                    case "find":
                        FindItem();
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

        //add new item  //lazy implementation
        static void AddItem()
        {
            try
            {
                Console.WriteLine("Item Types:  cburger | vburger | colddrink | hotdrink");
                Console.Write("Item Type:");
                String type = Console.ReadLine();
                MenuItem item;

                switch (type)
                {
                    case "cburger":
                        item = new ChickenBurger();
                        break;
                    case "vburger":
                        item = new VegBurger();
                        break;
                    case "colddrink":
                        item = new ColdDrink();
                        break;
                    case "hotdrink":
                        item = new HotDrink();
                        break;
                    default:
                        Console.WriteLine("Wrong type of item!");
                        return;
                }

                foreach (var prop in item.GetType().GetProperties())
                {
                    if (prop.Name.Equals("Id"))
                    {
                        continue;
                    }
                    Console.Write("{0}=", prop.Name);
                    prop.SetValue(item, ParseAnyObject(Console.ReadLine()));
                }

                restaurant.AddItem(item);
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine(e.ToString());
            }
        }

        //using reflection implementation, less code than AddItem()
        static void EditItem()
        {
            Console.Write("ID:");
            try
            {
                int id = int.Parse(Console.ReadLine());
                MenuItem oldItem = restaurant.GetItemById(id);
                MenuItem item = oldItem;
                
                foreach (var prop in item.GetType().GetProperties())
                {
                    if (prop.Name.Equals("Id"))
                    {
                        continue;
                    }
                    Console.WriteLine("Old {0}={1}", prop.Name, prop.GetValue(item, null));
                    Console.Write("New {0}=", prop.Name);
                    prop.SetValue(item, ParseAnyObject(Console.ReadLine()));
                }

                restaurant.EditItem(oldItem, item);
            }
            catch (Exception e)
            {               
                Console.WriteLine("Wrong input!");
                Console.WriteLine(e.Message.ToString());
            }
        }

        //deletes an item by id
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
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(restaurant.GetItemById(id).ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong input!");
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

            ColdDrink e = new ColdDrink();
            e.Name = "Beer";
            e.Price = 10;
            e.Volume = 250;
            e.HasSugar = true;
            restaurant.AddItem(e);
        }

        //helper function to parse any kind of object i need   int | double | bool
        private static object ParseAnyObject(String s)
        {
            try
            {
                return int.Parse(s);
            }
            catch(Exception e)
            {

            }

            try
            {
                return double.Parse(s);
            }
            catch (Exception e)
            {

            }

            try
            {
                return bool.Parse(s);
            }
            catch (Exception e)
            {

            }

            return s;
        }
    }
}
