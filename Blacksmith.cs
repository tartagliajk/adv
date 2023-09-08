using bobos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_game
{
    internal class Blacksmith
    {
        public static bool hasSoldSword;
        public static void Init()
        {
            Console.WriteLine("Hello dear stranger! Thank you so much for killing that truly evil squirrel!" +
                "\n Thats a... fine sword you have there! As a show of my grattitude i could take it off your hands" +
                "\n 10 Gold is a fair deal! What do you say?");
            if(Program.hasSword == true)
            { 
            if(Program.AskYesOrNo("Do you want to trade your rusty sword for 10 gold? [yes/no]"))
            {
                    Program.hasSword = false;
                    hasSoldSword = true;
                    Program.gold += 10;
                    Console.WriteLine("Are you headed towards to the tavern? You can take a shortcut to the bridge.");
                    Program.Ask("Do you want to go back or towards the bridge [back/bridge]");
                    switch(Program.response)
                    {
                        case "back":
                            Arena.Init();
                            break;
                        case "bridge":
                            Bridge.Init();
                            break;
                        default: Program.ErrorInput(); break;
                    }
            }
            }
        }
       
    }
}
