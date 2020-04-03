using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fttbll.Models
{
    public class ChampionshipCommand
    {
        public int ChampionshipCommandID { get; set; }
        public int ChampionshipID { get; set; }
        public int CommandID { get; set; }

        public Command Command { get; set; }
        public Championship Championship { get; set; }
    }
}
