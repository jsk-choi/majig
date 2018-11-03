using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majig.db.model
{
    public class vCategory
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int? ParentId { get; set; }
        public string Category { get; set; }
        public int? UserId { get; set; } 
        public string Crumb { get; set; }
    }
}
