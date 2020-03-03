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
        public class Sweepstakes
        {
            private Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            Random numberWinner = new Random();
            private registeredId;
            private string name;
            public string Name;
            public Sweepstakes(string name)
            {
                this.name = name;
            }

            public void RegisterContestant(Contestant contestant)
            {
                Contestant.registrationNumber = registeredId;
                contestants.Add(registeredId, contestant);
                registeredId++;
            }
        }
       



        //Constructor
        public Sweepstakes()
        {

        }

      

        public Contestant PickWinner()
        {
            Contestant winner;
            winner = contestants[numberWinner.Next(0, Contestant.Keys.Count)];
            name = winner.FirstName + " " + winner.LastName;
            winnerKey = winner.registrationNumber;
            return winner;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: " + contestant.FirstName + " " + contestant.LastName + ", ");
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
