using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majig.db.model
{
    public class Item
    {
        public int ItemId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string UniqueId { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
    }
}
