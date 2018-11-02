using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using majig.service;

namespace majig.web.Api
{
    public class ItemController : ApiController
    {
        private readonly IItemService ItemService;

        public ItemController(IItemService _ItemService)
        {
            this.ItemService = _ItemService;
        }

        // GET: api/Item
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", this.ItemService.getIt(33).ToString() };
        }

        // GET: api/Item/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Item
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Item/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
        }
    }
}
