using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fttbll.Models
{
    public class Match
    {
        [DataType(DataType.Date)]
        public DateTime DataProvedeniya { get; set; }
        public int Result { get; set;}
        public int CommandID { get; set; }
        public int MatchID { get; set; }
        public ICollection<Command> Commands { get; set; }
    }
}
