using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using majig.db;

namespace majig.service
{
    public interface IItemService
    {
        db.ef.Item Get(int id);
        IEnumerable<db.ef.vItems> Get();

        db.ef.Item Create(db.ef.Item item);
        db.ef.Item Update(db.ef.Item item);

        int Delete(db.ef.Item id);
    }
}
