using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fttbll.Models
{
    public class Player
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Command { get; set; }
       
        public ICollection<Player> Players { get; set; }
    }
}
