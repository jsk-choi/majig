using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using majig.db;

namespace majig.service
{
    public interface ICategoryService
    {
        db.ef.Category Get(int id);
        IEnumerable<db.ef.Category> Get();

        //db.ef.Category Create(db.ef.Category item);
        //db.ef.Category Update(db.ef.Category item);

        //int Delete(db.ef.Category id);
    }
}
