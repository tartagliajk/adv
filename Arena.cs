using bobos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_game
{
    internal class Arena
    {
        public static void Init()
        {
            if (FightScript.squirrelAlive == false)
            {
                Console.WriteLine("The squirrel is dead");
                {
                    while (true)
                    {
                        if (Program.AskYesOrNo("Do you want to turn back around? [yes/no]"))
                        {
                            Room_1.Init();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Okay stare at the dead squirrel.");
                        }
                    }
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("You coninue deeper into the forest");
                Thread.Sleep(1000);
                Console.WriteLine("You come across a mighty Squirrel, weilding a mighty hammer");
                FightScript.Combat(1, "Squirrel");
            }
        }
    }
}
