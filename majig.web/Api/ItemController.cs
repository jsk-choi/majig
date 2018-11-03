using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AutoMapper;

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
        public IHttpActionResult Get()
        {
            var items = ItemService.Get();
            var itemsDto = Mapper.Map<IEnumerable<db.model.Item>>(items);
            return Ok(itemsDto);
        }

        // GET: api/Item/5
        public IHttpActionResult Get(int id)
        {
            var item = ItemService.Get(id);
            var itemDto = Mapper.Map<db.model.Item>(item);
            return Ok(itemDto);
        }

        // POST: api/Item
        public void Post([FromBody]db.model.Item item)
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
