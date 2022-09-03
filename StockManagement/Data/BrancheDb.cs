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

    }
}
