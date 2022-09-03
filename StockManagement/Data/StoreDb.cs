using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class StoreDb
    {
        private readonly StockDbContext _context;
        public StoreDb(StockDbContext context)
        {
            _context = context;
        }

    }
}
