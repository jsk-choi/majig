using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using majig.db;

namespace majig.service
{
    public class CategoryService : ICategoryService
    {
        public db.ef.Category Get(int id)
        {
            using (var ctx = new db.ef.MajigContext())
            {
                return ctx.Category.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<db.ef.Category> Get()
        {
            using (var ctx = new db.ef.MajigContext())
            {
                return ctx.Category.ToList();
            }
        }

        //public db.ef.Category Create(db.ef.Item item)
        //{
        //    throw new NotImplementedException();
        //}
        //public db.ef.Item Update(db.ef.Item item)
        //{
        //    throw new NotImplementedException();
        //}
        //public int Delete(db.ef.Item item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
