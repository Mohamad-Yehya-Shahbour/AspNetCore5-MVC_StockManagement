using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class ItemDb
    {
        private readonly StockDbContext _context;
        public ItemDb(StockDbContext context)
        {
            _context = context;
        }

    }
}
