using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;

namespace costadelsoltapas.ViewModels
{
    public class TapasListViewModel
    {
        public IEnumerable<Tapas> Tapas { get; set; }
        public string CurrentCategory { get; set; }
    }
}
