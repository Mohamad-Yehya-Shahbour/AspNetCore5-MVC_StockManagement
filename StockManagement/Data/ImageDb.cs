using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class ImageDb
    {
        private readonly StockDbContext _context;
        public ImageDb(StockDbContext context)
        {
            _context = context;
        }

    }
}