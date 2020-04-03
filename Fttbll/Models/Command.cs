using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fttbll.Models
{
    public class Command
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CommandID { get; set; }
        public int PlayerID { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
