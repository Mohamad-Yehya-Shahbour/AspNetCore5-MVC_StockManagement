using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class BrancheDb
    {
        private readonly StockDbContext _context;
        public BrancheDb(StockDbContext context)
        {
            _context = context;
        }

        public Branche Add(Branche Branche)
        {
            _context.Branches.Add(Branche);
            _context.SaveChanges();
            return Branche;
        }

        public Branche Update(Branche Branche)
        {
            Branche branchedb = GetById(Branche.Id);
            if (branchedb != null)
            {
                branchedb.Name = Branche.Name;
                branchedb.ManagerName = Branche.ManagerName;
                _context.SaveChanges();
            }
            return Branche;
        }

    }
}
