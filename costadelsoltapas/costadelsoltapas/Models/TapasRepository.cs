using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using costadelsoltapas.Models;

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

        public Tapas GetTapasById(int tapasId)
        {
            return _appDbContext.Tapas.FirstOrDefault(p => p.TapasId == tapasId);
        }
    }
}
