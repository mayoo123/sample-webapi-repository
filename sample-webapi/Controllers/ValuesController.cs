using Microsoft.AspNetCore.Mvc;
using sample_webapi.Model;
using sample_webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IInventoryServices _service;
        public ValuesController(IInventoryServices inventoryServices)
        {
            _service = inventoryServices;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<InventoryItem> Get()
        {
            return NotFound(); //new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<List<InventoryItem>> Post([FromBody] InventoryItem inventoryItem)
        {
            var inventoryItems = _service.AddInventoryItem(inventoryItem);
            if(inventoryItems == null)
            {
                return NotFound();
            }

            return inventoryItems;


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
