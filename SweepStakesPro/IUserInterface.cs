using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    public static class IUserInterface
    {
        public static Contestant GetUserInfo()
        {
            Contestant contestant = new Contestant();
            Console.Write("Enter your First name: ");
            contestant.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            contestant.LastName = Console.ReadLine();
            Console.Write("Enter your email address: ");
            contestant.EmailAddress = Console.ReadLine();
            return contestant;
        }
        public static string SweepstakesName()
        {
            Console.WriteLine("What is the name of this sweepstakes?");
            return Console.ReadLine();
            {
                public static ISweepstakesManager PickManager()
                {
                    ISweepstakesManager pickManager;
                    string pick;
                    do
                    {
                        Console.WriteLine("How would you like your sweepstakes to be managed? stack or queue?");
                        pick = Console.ReadLine().ToLower();
                    }
                    while (pick != "stack" && pick != "queue");
                    if (pick == "stack")
                    {
                        pickManager = new SweepstakesStackManager();
                        return pickManager;
                    }
                    else if (pick == "queue")
                    {
                        pickManager = new SweepstakesQueueManager();
                        return pickManager;
                    }
                    return null;
                }

                public static string SetSweepstake()
                {
                    Console.Clear();
                    Console.WriteLine("What is the name of sweepstake?");
                    return Console.ReadLine();
                }

                public static void AnnouceWinner(Sweepstakes sweepstakes)
                {
                    Console.WriteLine("Winner of the Sweepstakes is: " + sweepstakes.name);

                }
            }
        }
    }
