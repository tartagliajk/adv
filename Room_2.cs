using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobos
{
    internal class Room_2
    {
        public static void Init()
        {
            Random r = new Random();
            int rInt = r.Next(0, 2);

            Console.WriteLine("You fix the bridge and you walk towards the tavern" +
                "\n On your way you get approached by a merchant");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Thats a nice hammer! I'd very much like to trade for it. I have this golden ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Crown!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("It would be a very good deal!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (Program.AskYesOrNo("Do you want to exchange the crown for the hammer? [yes/no]"))
            {
                Program.hasHammer = false;
                Program.hasCrown = true;
                Console.WriteLine("You decided to exchange the crown for the hammer... it will make a good component to your collection");
            }
            else
            {
                Console.WriteLine("You decided to not pick the crown up... It's probably not even real gold");
            }
            Console.WriteLine("You continue foward and you arrive at the tavern, the bartender gives you a quick smile.");
            if (rInt == 0)
            {
                Console.WriteLine("The bartender puts a cup of jucie infront of you.");
            }
            else if (rInt == 1)
            {
                Console.WriteLine("The bartender puts a glass of beer infront of you");
            }
            Console.WriteLine("You finish your drink and have a chat with the bartender." +
                "\nHe explains that he has 2 objects to offer you for your future adventures but you can only take one" +
                "\nIt is either a compass or a map");
            Program.Ask("What will it be? [compass/map ]");
            switch (Program.response)
            {
                case "compass":
                        Console.WriteLine("You decide to take the compass");
                        break;

                case "map":
                    Console.WriteLine("You decide to take the map");
                        break;
            }

            Console.WriteLine("Temporary End");
        }
    }
}
