using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costadelsoltapas.Models
{
    public interface ITapasRepository
    {
        IEnumerable<Tapas> AllTapas { get; }
        IEnumerable<Tapas> TapasOfTheWeek { get; }
        Tapas GetTapasById(int TapasId);
    }
}
