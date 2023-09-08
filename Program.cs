using System.Diagnostics.SymbolStore;
using System.Resources;

namespace bobos
{
    internal class Program
    {
        public static double playerHP = 10;
        public static int playerStamina = 5;
        public static string playerName;
        public static string response;

        //Inv
        public static int gold;
        public static bool hasSword;
        public static bool hasHammer = false;
        public static bool hasCrown = false;
        public static bool hasCompas;
        public static bool hasMap;
        public static bool hasTicket;

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("You find yourself in a dark room and suddenly a voice starts to speak to you.");
            Console.WriteLine("Hello, Player!");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("What is your nanme?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            playerName = Console.ReadLine().ToLower();
            if (playerName != "bobo")
            {
                Console.Write("Thats too complicated. ");
                Thread.Sleep(1500);
                Console.Write("I'll just call you... ");
                Thread.Sleep(1000);
                Console.Write("BOBO!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(2000);
                Console.WriteLine("\nBobo the Brave!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("If you really want to change your name, type 2. otherwise type 1 to continue");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    playerName = "Bobo";
                    Room_1.Init();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Okay okay, what's your name?");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    playerName = Console.ReadLine();
                    Room_1.Init();
                }
            }
        }

        public static string Ask(string quesiton)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(quesiton);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                response = Console.ReadLine().Trim();
                response = response.ToLower();

            } while (response == "");
            return response;
        }

        public static bool AskYesOrNo(string question)
        {
            while (true)
            {
                response = Ask(question);
                switch (response)
                {
                    case "yes":
                    case "ok":
                        return true;
                    case "no":
                        return false;
                    default:
                        ErrorInput();
                        break;
                }
            }
        }

        public static void ErrorInput()
        {
            Console.WriteLine("Error invalid input");
        }
    }
}