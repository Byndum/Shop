using Shop.Application;
using Shop.Domain;
using Shop.Entities;
using Shop.Infrastructur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            // Testing123:
            Item u1 = new Item("g456","guldhalskæde",4580.50);
            Console.WriteLine(u1.Description);

            // lav en instans af FileItemRepos (husk stien til filerne)
            string filePath = "C:/Users/mikae/source/repos/Shop/Shop/Files/Items.txt";
            FileItemRepos fileItemRepos = new FileItemRepos(filePath);

            
            // lav en instans af use case #1..
            LoadItemsUseCase loadItems = new LoadItemsUseCase(fileItemRepos);
            // List<Item> items = "kald metoden i use case #1 for at hente alle items" 
            List<Item> items = loadItems.Execute();
            foreach (Item item in items)
            {
                Console.WriteLine($"[{item.Id}] {item.Description}: price: {item.Price} usd");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Which one would you like to buy?: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            if (choice > 0 && choice <= items.Count)
            {
                Console.WriteLine($"Bought: [{items[choice-1].Id}] {items[choice-1].Description}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Would you like your order gift wrapped?");
            Console.WriteLine("[1]: Yes!");
            Console.WriteLine("[2]: No!");

            int wrappingChoice = int.Parse(Console.ReadLine() ?? "2");
            IItem giftWrapping = null;

            if (wrappingChoice == 1)
            {
                giftWrapping = new GiftWrapping(items[choice-1]);
            }
            
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Would you like your order shipped to your home address?");
            Console.WriteLine("[1]: Yes!");
            Console.WriteLine("[2]: No!");

            int shipmentChoice = int.Parse(Console.ReadLine() ?? "2");
            IItem shipment = null;

            if (shipmentChoice == 1)
            {
                shipment = new Shipment(giftWrapping);
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(shipment.getDesc());
            Console.WriteLine(shipment.getPrice());
        }
    }
}
