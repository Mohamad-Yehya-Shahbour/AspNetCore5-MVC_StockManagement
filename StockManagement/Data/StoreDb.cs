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

        public Store Update(Store Store)
        {
            Store storedb = GetById(Store.Id);
            if (storedb != null)
            {
                storedb.Name = Store.Name;
                storedb.BrancheId = Store.BrancheId;
                _context.SaveChanges();
            }
            return Store;
        }

        public void Delete(int StoreId)
        {
            Store store = GetById(StoreId);
            if (store != null)
            {
                _context.Stores.Remove(store);
                _context.SaveChanges();
            }
        }

    }
}
