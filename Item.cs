using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_craft_system
{
    public class Item
    {
        public string Name { get; set; }
        public string Symbole { get; set; }
        public string Color { get; set; }

        public Item(string name,string symbole,string color)
        {
            this.Name = name;
            this.Symbole = symbole;
            this.Color = color.ToUpper();
        }

        public override string ToString()
        {
            return Symbole;
        }
        public void text()
        {

            if (Color == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (Color == "DARKGRAY")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            string text = Symbole;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
