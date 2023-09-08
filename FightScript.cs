using adv_game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobos
{
    internal class FightScript
    {
        public static bool squirrelAlive = true;

        public static void Combat(int hp, string name)
        {
            Console.WriteLine($"You're fighting a {name} with the hp of {hp}");
            Console.WriteLine("You have no choice but to defeat it");
            while (hp >= 1 && Program.playerHP > 0)
            {
                PlayerAction();
            }
            if(hp <= 0)
            {
                squirrelAlive = false;
                Program.hasHammer = true;
                bool tof = true;
                Console.WriteLine("You have slain the Mighty Squirrel and you pick up his Hammer");
                Console.WriteLine("You spot a blacksmith further into the forest.");
                while (tof == true)
                {
                    Program.Ask("Do you want to approach the blacksmith or turn back around? [blacksmith/turn]");
                    switch(Program.response)
                    {
                        case "blacksmith":
                            Blacksmith.Init();
                            tof = false;
                            break;
                        case "turn":
                            Room_1.Init();
                            tof = false;
                            break;
                        default:
                            Console.WriteLine("Okay stare at the dead squirrel.");
                            break;
                    }
                }
            }else if(Program.playerHP <= 0) 
            {
                Console.WriteLine("You have died");
            }

            void SquirrelAttack()
            {
                Random r = new Random();
                int rInt = r.Next(0, 2);
                if (rInt == 0)
                {
                    Program.playerHP -= 1;
                    Console.WriteLine("Squirrel bites you, dealing 1 HP");
                }
                else if (rInt == 1)
                {
                    Program.playerHP -= 2;
                    Console.WriteLine("Squirrel swings it's hammer at you, dealing 2 HP");
                }
            }

            void Rest()
            {
                Program.playerHP -= 0.5;
                Program.playerStamina += 2;
                PlayerStatus();
                Console.WriteLine("You rested and gained 2 stamina");
            }

            void PlayerStatus()
            {
                Console.WriteLine($"Enemy HP: {hp}                           {Program.playerName} HP: {Program.playerHP}");
                Console.WriteLine($"Player Stamina: {Program.playerStamina}");
            }

            void PlayerAction()
            {
                Console.WriteLine("You have three options");
                if(Program.hasSword == true)
                {
                    Console.WriteLine("Swing --- Dealing 7 : Cost 5 Stamina");
                }
                else
                {
                    Console.WriteLine("Punch --- Dealing 2 DMG : Cost 1 Stamina");
                }
                Console.WriteLine("Kick  --- Dealing 5 DMG : Cost 3 Stamina");
                Console.WriteLine("Rest  --- Takes dmg for a turn but you gain stamina");
                PlayerStatus();
                Program.Ask("What do you want to do?");
                switch (Program.response)
                {
                    case "punch":
                        if(Program.playerStamina >= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("You punched the squirrel");
                            SquirrelAttack();
                            hp -= 2;
                            Program.playerStamina -= 1;
                            PlayerStatus();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Error insufficient stamina");
                            Rest();
                        }
                        
                        break;
                    case "kick":
                        if( Program.playerStamina >= 3)
                        {
                            Console.Clear();
                            Console.WriteLine("You kicked the squirrel");
                            SquirrelAttack();
                            hp -= 5;
                            Program.playerStamina -= 3;
                            PlayerStatus();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Error insufficient stamina");
                            Rest();
                        }
                        break;
                    case "swing":
                        if(Program.hasSword == true)
                        {
                            if(Program.playerStamina >= 5)
                            {
                                Console.Clear();
                                Console.WriteLine("You swung the sword at the squirrel");
                                SquirrelAttack();
                                hp -= 7;
                                Program.playerStamina -= 5;
                                PlayerStatus();
                            }
                            else
                            {
                                Console.WriteLine("Error insufficient stamina");
                                Rest();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You do not have a mighty sword, get rekt");
                            SquirrelAttack();
                            PlayerStatus();
                        }
                        break;
                    case "rest":
                        Console.Clear();
                        Rest();
                        break;
                    default:
                        Program.ErrorInput();
                        break;
                }
            }
        }
    }
}
