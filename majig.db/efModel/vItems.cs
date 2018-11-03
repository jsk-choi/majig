namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vItems
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string BrandName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategorId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Category { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(2000)]
        public string ItemDesc { get; set; }

        [StringLength(100)]
        public string UniqueId { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Price { get; set; }
    }
}
