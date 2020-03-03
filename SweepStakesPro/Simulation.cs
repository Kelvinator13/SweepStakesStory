using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    class Simulation
    {
       public class Simulation
        {
            public Simulation()
        }
        
        public void CreateMarketingFirmWithManager()
        {
            IsweepstakesManager sweepstakesManager;
            sweepstakesManager = IUserInterfce.PickManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepStakes();
        }

    }
}
