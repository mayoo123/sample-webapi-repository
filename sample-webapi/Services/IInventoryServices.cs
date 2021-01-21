using sample_webapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Services
{
    public interface IInventoryServices
    {
        List<InventoryItem> AddInventoryItem(InventoryItem inventoryItem);
    }
}
