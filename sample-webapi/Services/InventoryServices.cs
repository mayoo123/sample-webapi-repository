using sample_webapi.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Services
{
    public class InventoryServices : IInventoryServices
    {
        private List<InventoryItem> _list = new List<InventoryItem>();
        public List<InventoryItem> AddInventoryItem(InventoryItem inventoryItem)
        {
            _list.Add(inventoryItem);
            return _list;
        }


       public List<InventoryItem> GetFromDb()
        {
            SqlConnection conn = new SqlConnection();
        }
    }
}
