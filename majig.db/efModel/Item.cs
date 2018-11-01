namespace majig.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            BuildDetail = new HashSet<BuildDetail>();
            CompatDetail = new HashSet<CompatDetail>();
            Item1 = new HashSet<Item>();
        }

        public int Id { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(100)]
        public string UniqueId { get; set; }

        public int? ParentId { get; set; }

        public int? CategoryId { get; set; }

        public int? ConfigHeaderId { get; set; }

        public int? BrandId { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(2000)]
        public string ItemDesc { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildDetail> BuildDetail { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompatDetail> CompatDetail { get; set; }

        public virtual ConfigHeader ConfigHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item1 { get; set; }

        public virtual Item Item2 { get; set; }
    }
}
