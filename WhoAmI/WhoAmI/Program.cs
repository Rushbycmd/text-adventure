using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure2
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();

        }
        /* this section will demonstrate writing to the console 6/11*/
        public static void gameTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗");
            Console.WriteLine("╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(2000);
            Console.WriteLine("Who Am I?");
            Task.Delay(5000);
            Console.WriteLine("Who are you?");
            Task.Delay(5000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Game Done By Rushuby The dumbass©");
            Console.WriteLine("╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗╔═╗");
            Console.WriteLine("╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝");
            Task.Delay(5000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /* this section will demonstrate switches 6/11*/
        public static void first()
        {
            string choice;

            Console.WriteLine("Welcome Hooman! I am the Great Rushbaby, the one and only.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Who Am I?");
            Console.WriteLine("2. Dababy?");
            Console.WriteLine("3. You are gay Rushuby!!!");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "question":
                case "seek":
                    {
                        Console.WriteLine("You are Stupid, your name that is.");
                        Console.WriteLine("And I am Rushbaby your lord and savor.");
                        Console.WriteLine("This is my queen pokimaine, she is the ruler of my world ;)");
                        second();
                        break;
                    }
                case "2":
                case "brh":
                    {
                        Console.WriteLine("Boi stat the fak ap oimafgod");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
            
                case "3":
                case "You are gay rushuby":
                case "rushuby":
                    {
                Console.WriteLine("You called rushuby gay...");
                Console.WriteLine("You died");
                Console.WriteLine("Rushuby teabagged you.....?"); 
                Console.ReadLine();
                        gameOver();
                break;
            }
            default:
                    {

                        Console.WriteLine("Yo noob that command is invalid... be valid or draw 25 cards");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }
        /* this section will demonstrate using random number generator and also allowing player to enter text response 6/18*/
        public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = {
            "What wish you want? Pokimaine?"};
            int randomNumber = rnd.Next(0, 1);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Yes Or No (Y/N)");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.ReadLine();
                Console.Clear();
                gameOver();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("RUSHUBY FUCKING LOSES IT");
                third();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }


        public static void third()

        {
            int Decision;
            Console.WriteLine("Rushuby Growls Begging for crack (and for being insulted duh)");
            Console.WriteLine("You see in the distance  A FUCKING MODERATOR (OH SHIT)");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool dead = false;
            while (Decision != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, the mod YEETS YOU TO SHITPOSTS");
                    Console.WriteLine("You are bleeding profusely now,?");
                    Console.ReadLine();
                    modOver();
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("You are too slow, the mod YEETS YOU TO SHITPOSTS");
                    Console.WriteLine("You are bleeding profusely now,?");
                    Console.ReadLine();
                    modOver();
                }

            }
            if (dead == true)
            {
                Console.WriteLine("You karate kick the mod.");
                Console.WriteLine("The mod dies.");
                Console.ReadLine();
                modWon();
            }
            else

            {
                Console.WriteLine("You become the moderator.");
                Console.ReadLine();
                youWin();
            }
        }


        public static void modOver()
        {
            Console.Clear();
            Console.WriteLine("The true ending.");
            Console.WriteLine("You have died.");
            Console.WriteLine("....?");
            Console.WriteLine("By A MODERATOR???");
            Console.WriteLine("Such a shit hooman and such a shit ending?");
            Console.WriteLine("Thank you nerd for playing");
            Console.WriteLine("It was very fun coding this (lie)");
            Console.WriteLine("But I love that you tried this shitty excuse for a game");
            Console.WriteLine("Now can you fucking talk in lounge and tell me how you felt about it?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("The you can't actually have a good ending ever ending.");
            Console.WriteLine("You have died.");
            Console.WriteLine("Unfortunantly, countless fortnite kids outlived you.");
            Console.WriteLine("The End?");
            Console.WriteLine("Thank you nerd for playing");
            Console.WriteLine("It was very fun coding this (lie)");
            Console.WriteLine("But I love that you tried this shitty excuse for a game");
            Console.WriteLine("Now can you fucking talk in lounge and tell me how you felt about it?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("The good ending.");
            Console.WriteLine("You have survived.");
            Console.WriteLine("Rushuby reveals a box...");
            Console.WriteLine("You are saved? Or are you trapped in something even worse...?");
            Console.WriteLine("Thank you nerd for playing");
            Console.WriteLine("It was very fun coding this (lie)");
            Console.WriteLine("But I love that you tried this shitty excuse for a game");
            Console.WriteLine("Now can you fucking talk in lounge and tell me how you felt about it?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void modWon()
        {
            Console.Clear();
            Console.WriteLine("The ending that is most shit ending.");
            Console.WriteLine("You became a mod");
            Console.WriteLine("....?");
            Console.WriteLine("Holy shit I am dissapointed.");
            Console.WriteLine("Such a shit hooman and such a shit ending?");
            Console.WriteLine("Thank you nerd for playing");
            Console.WriteLine("It was very fun coding this (lie)");
            Console.WriteLine("But I love that you tried this shitty excuse for a game");
            Console.WriteLine("Now can you fucking talk in lounge and tell me how you felt about it?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}


