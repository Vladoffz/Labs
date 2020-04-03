using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fttbll.Services
{
    public class AutorInfoSender : IAutor
    {
        public string Send()
        {
            return "Autor: Gundarchuk Vlad. Age: 20. Dobavil servis v 21:20.";
        }
    }
}
