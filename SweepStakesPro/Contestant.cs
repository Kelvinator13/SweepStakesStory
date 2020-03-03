using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    public class Contestant : IContestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        public int RegistrationNumber;
        public string Name { get { return Name; } set { Name = firstName; } }
        int name { get; set; }

        public interface IContestant
        {
            int name { get; set; }
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { LastName = value; } }
        public string EmailAddress { get { return EmailAddress; } set { emailAddress = value; } }

        public void Inform(IContestant contestant)
        {
            Console.WriteLine("Input received, {0} ", contestant.name);
        }


    }
}
