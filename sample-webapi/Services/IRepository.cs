using sample_webapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Services
{
    public interface IRepository
    {
        List<InventoryItem> Get();
        InventoryItem Get(int id);
        InventoryItem Add(InventoryItem item);
        InventoryItem UPDATE(InventoryItem item);
        InventoryItem DELETE(InventoryItem item);

    }
}
