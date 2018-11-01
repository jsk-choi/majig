namespace majig.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildDetail")]
    public partial class BuildDetail
    {
        public int Id { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public int BuildHeaderId { get; set; }

        public int? ItemId { get; set; }

        public int? ConfigHeaderId { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(500)]
        public string ItemDescription { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public virtual BuildHeader BuildHeader { get; set; }

        public virtual Item Item { get; set; }
    }
}
