using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    class MarketingFirm
    {
        private ISweepstakesManager_manager;
        public MarketingFirm(IsweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepStakes()
        {
            string more = "yes";
            Sweepstakes sweepstakes = new Sweepstakes(IUserInterface.SweepstakesName());
            sweepstakes.RegisterContestant(IUserInterface.GetUserInfo());
            Console.WriteLine("Would you like to iput another Contestant? 'Yes' or 'No'");
            more = Console.ReadLine();
            {
                sweepstakes.PickWinner();
                IUserInterface.AnnounceWinner(sweepstakes);
                IUserInterface.Inform(Sweepstakes);

            }


        }
    }
}
