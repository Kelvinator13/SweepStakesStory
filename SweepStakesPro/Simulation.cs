using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    class Simulation
    {
       public class SimulationSweep
        {

        }
        
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;
            sweepstakesManager = IUserInterface.PickManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepstakes();
        }

    }
}
