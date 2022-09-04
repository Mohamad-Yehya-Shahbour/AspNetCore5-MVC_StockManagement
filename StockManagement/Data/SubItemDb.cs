using StockManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement.Data
{
    public class SubItemDb
    {
        private readonly StockDbContext _context;
        public SubItemDb(StockDbContext context)
        {
            _context = context;
        }

        public SubItem Add(SubItem SubItem)
        {
            _context.SubItems.Add(SubItem);
            _context.SaveChanges();
            return SubItem;
        }

        public SubItem Update(SubItem SubItem)
        {
            SubItem subItemdb = GetById(SubItem.Id);
            if (subItemdb != null)
            {
                subItemdb.Name = SubItem.Name;
                subItemdb.ImageUrl = SubItem.ImageUrl;
                subItemdb.ItemId = SubItem.ItemId;

                _context.SaveChanges();
            }
            return SubItem;
        }

    }
}