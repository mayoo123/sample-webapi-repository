using sample_webapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Services
{
    public class Repository : IRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public Repository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }
        public InventoryItem Add(InventoryItem item)
        {
            _inventoryDbContext.InventoryItems.Add(item);
            _inventoryDbContext.SaveChanges();
            return item;
        }

        public InventoryItem DELETE(InventoryItem item)
        {
            throw new NotImplementedException();
        }

        public List<InventoryItem> Get()
        {
            throw new NotImplementedException();
        }

        public InventoryItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public InventoryItem UPDATE(InventoryItem item)
        {
            throw new NotImplementedException();
        }
    }
}
