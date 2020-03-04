using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesPro
{
    public interface IContestant
    {
        string Name { get; set; }

        void Inform(IContestant contestant);
    }
}
