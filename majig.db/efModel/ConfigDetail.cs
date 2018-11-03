namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigDetail")]
    public partial class ConfigDetail
    {
        public int Id { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public int ConfigHeaderId { get; set; }

        public int? CategoryId { get; set; }

        public short Quantity { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public bool IsRequired { get; set; }

        public virtual Category Category { get; set; }

        public virtual ConfigHeader ConfigHeader { get; set; }
    }
}
