using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    public class Sweepstakes
    {
        
        //member variable
        private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public List<string> contestantsNames = new List<string>();
        Random numberWinner = new Random();
        public string name;
        public string Name;
        private int registeredId;
        public int winnerKey;

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //Methods


        public void RegisterContestant(Contestant  lcontestant)
        {
            contestant.RegisteredNumbers = registeredId;
            contestants.Add(registeredId, contestants);
            registeredId++;
        }
        public Contestant PickWinner()
        {
            Contestant winner;
            winner = contestants[numberWinner.Next(0, Contestant.Keys.Count)];
            name = winner.FirstName + " " + winner.LastName;
            winnerKey = winner/;
            return winner;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: " + contestant.FirstName + " " + contestant.LastName + ", ");
            Console.WriteLine("email: " + contestant.EmailAddress + ", ");
            Console.WriteLine("registration number: " + contestant.RegisteredNumbers); 
            Console.WriteLine();
        }

        public void ContestantsNameToList()
        {
            for (int i = 0; i < Contestant.Count; i++)
            {
                contestantsNames.Add(ContestantsNameToList[i].FirstName);
            }
        }
        public void Inform()
        {
            foreach(var name in contestantsNames)
            {
                Contestant contestant = new Contestant();
                contestant.Inform(contestant);
            }
        }
    }
}
