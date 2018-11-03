using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using majig.db;

namespace majig.service
{
    public class ItemService : IItemService
    {
        public db.ef.Item Get(int id)
        {
            using (var ctx = new db.ef.MajigContext())
            {
                return ctx.Item.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<db.ef.vItems> Get()
        {
            using (var ctx = new db.ef.MajigContext())
            {
                return ctx.vItems.ToList();
            }
        }

        public db.ef.Item Create(db.ef.Item item)
        {
            using (var ctx = new db.ef.MajigContext())
            {
                ctx.Item.Add(item);
                ctx.SaveChanges();
                return item;
            }
        }
        public db.ef.Item Update(db.ef.Item item)
        {
            using (var ctx = new db.ef.MajigContext())
            {
                var thisItem = ctx.Item.Where(x => x.Id == item.Id).FirstOrDefault();

                if (thisItem != null)
                {
                    thisItem.Id = item.Id;
                    thisItem.Active = item.Active;
                    thisItem.UniqueId = item.UniqueId;
                    thisItem.ParentId = item.ParentId;
                    thisItem.CategoryId = item.CategoryId;
                    thisItem.CreateDate = DateTime.Now;
                    thisItem.ConfigHeaderId = item.ConfigHeaderId;
                    thisItem.BrandId = item.BrandId;
                    thisItem.ItemName = item.ItemName;
                    thisItem.ItemDesc = item.ItemDesc;
                    thisItem.Url = item.Url;
                    thisItem.Price = item.Price;
                    ctx.SaveChanges();
                }

                return thisItem;
            }
        }
        public int Delete(db.ef.Item item)
        {
            using (var ctx = new db.ef.MajigContext())
            {
                var thisItem = ctx.Item.Where(x => x.Id == item.Id).FirstOrDefault();

                if (thisItem != null)
                {
                    ctx.Item.Remove(thisItem);
                    return ctx.SaveChanges();
                }
                else {
                    return 0;
                }
            }
        }
    }
}
