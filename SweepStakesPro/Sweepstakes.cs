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
        public class SweepStakers
        {
            private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            public List<string> contestantsNames = new List<string>();
            Random numberWinner = new Random();
            private int registeredId;
            private string name;
            public string Name;
            public SweepStakers(string name)
            {
                this.name = name;
            }

            public void RegisterContestant(Contestant contestant)
            {
                contestant.RegistrationNumber = registeredId;
                contestants.Add(registeredId, contestant);
                registeredId++;
            }
        }
      

        //Constructor
       

        public Contestant PickWinner()
        {
            Contestant winner;
            winner = contestants[numberWinner.Next(0, Contestant.Keys.Count)];
            name = winner.firstName + " " + winner.LastName;
            winnerKey = winner.registrationNumber;
            return winner;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: " + contestant.firstName + " " + contestant.LastName + ", ");
            Console.WriteLine("email: " + contestant.EmailAddress + ", ");
            Console.WriteLine("registration number: " + contestant.registrationNumber);
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
