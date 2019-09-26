using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costadelsoltapas.Models
{
    public class TapasRepository : ITapasRepository
    {
        private readonly AppDbContext _appDbContext;
        public TapasRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Tapas> AllTapas
        {
            get
            {
                return _appDbContext.Tapas.Include(c => c.Category);
            }
        }

        public IEnumerable<Tapas> TapasOfTheWeek
        {
            get
            {
                return _appDbContext.Tapas.Include(c => c.Category).Where(p => p.IsTapasOfTheWeek);
            }
        }

        public Tapas GetTapasById(int tapasID)
        {
            return _appDbContext.Tapas.FirstOrDefault(p => p.TapasID == tapasID);
        }
    }
}
