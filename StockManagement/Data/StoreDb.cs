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

        public Store Add(Store Store)
        {
            _context.Stores.Add(Store);
            _context.SaveChanges();
            return Store;
        }
    }
}
