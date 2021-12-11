using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_craft_system
{
    class Inventory
    {
        public Dictionary<Item,int> Stuff { get; set; }

        public Inventory(Dictionary<Item,int> stuff)
        {
            this.Stuff = stuff;
        }

        public void AddItems(Item item, int number)
        {
            Stuff.Add(item, number);
        }

        public override string ToString()
        {
            string text = "";
            foreach (Item a in Stuff.Keys)
            {
                Stuff.TryGetValue(a, out int nombre);
                text += (a.ToString()) + " x"+ nombre + " ";
            }
            return text;
        }
    }
}
