using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;

namespace costadelsoltapas.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tapas> TapasOfTheWeek { get; set; }
    }
}
