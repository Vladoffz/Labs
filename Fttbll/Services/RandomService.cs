using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fttbll.Services
{
    public class RandomService : ICounter
    {
        static Random RandomnoeChislo = new Random();
        private int _value;
        public RandomService()
        {
            _value = RandomnoeChislo.Next(0, 1000000);
        }
        public int Value
        {
            get { return _value; }
        }
    }
}
