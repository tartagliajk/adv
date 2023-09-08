using bobos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_game
{
    internal class Bridge
    {
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("You proceed down towards the bridge. As you get closer you notice that the bridge is broken and you cannot cross the violent river");
            Console.WriteLine("On the other side you see a cozy tavern, wonder what could be insie.");
            if (Program.hasHammer == false)
                Console.WriteLine("If only you had a hammer to fix this bridge...");
            else
                Console.WriteLine("The squrrels hammer should work just fine as a repair tool");

            if (Program.hasHammer == true)
            {
                while (true)
                {
                    if (Program.AskYesOrNo("Do you want to fix the bridge? [yes/no]"))
                    {
                        Room_2.Init();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Okay... Wait here then");
                    }
                }

            }
            else
            {
                if (Program.hasSword == false && Blacksmith.hasSoldSword == false)
                {
                    Console.WriteLine("From a distance you spot a rusty sword");
                    if (Program.AskYesOrNo("Do you want to pick the sword up? [yes/no]"))
                    {
                        Console.WriteLine("You have picked up the mighty rusty sword!");
                        Program.hasSword = true;
                    }
                    else
                    {
                        Console.WriteLine("Why pick up trash when u can be cool!");
                    }
                }
                while (true)
                {
                    if (Program.AskYesOrNo("Do you want to turn back around? [yes/no]"))
                    {
                        Room_1.Init();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ok");
                    }
                }
            }

        }
    }
}
