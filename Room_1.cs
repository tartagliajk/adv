using adv_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobos
{
    internal class Room_1
    {
        public static void Init()
        {
            bool correctInput = false;
            Console.Clear();
            if (FightScript.squirrelAlive == false)
            {
                Console.WriteLine("You find yoursel back at the crossroads" +
                    "\nTo your right you see a bridge that leads over a violent river" +
                    "\nTo your left you the a path continues deeper into the forest");
            }
            else
            {
                Console.WriteLine("You find yoursel at a crossroads in a forest" +
                    "\nTo your right you see a bridge that leads over a violent river" +
                    "\nTo your left you the a path continues deeper into the forest");
            }

            //loopar tills spelaren svarar rätt
            while (correctInput == false)
            {
                Program.Ask("Were do you want to go? [left/right]");
                switch (Program.response)
                {
                    case "right":
                        {
                            correctInput = true;
                            Bridge.Init();
                            break;
                        }
                    case "left":
                        {
                            correctInput = true;
                            Arena.Init();
                            break;
                        }
                    default:
                        {
                            Program.ErrorInput();
                            break;
                        }
                }
            }
        }

        
        
    }
}
