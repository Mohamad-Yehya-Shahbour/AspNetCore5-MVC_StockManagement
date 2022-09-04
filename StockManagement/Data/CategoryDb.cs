using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class CategoryDb
    {
        private readonly StockDbContext _context;
        public CategoryDb(StockDbContext context)
        {
            _context = context;
        }

        public Category Add(Category Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return Category;
        }
    }
}
