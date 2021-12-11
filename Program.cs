using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_craft_system
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Item stick = new Item("stick", "/","red");
            //stick.ToString();
            Item stone = new Item("stone", "■", "darkgray");
            //stone.ToString();
            int num = 45;
            int num2 = 4;
            Dictionary<Item, int> stuff = new Dictionary<Item, int>();
            stuff.Clear();
            stuff.Add(stick, num);
            stuff.Add(stone, num2);
            Inventory inventory = new Inventory(stuff);
            //inventory.AddItems(stick,num2);
            //inventory.AddItems(stone,num);
            Console.WriteLine(inventory.ToString());

            Console.ReadKey();
        }
    }
}
