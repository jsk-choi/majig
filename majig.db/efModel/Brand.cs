namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brand()
        {
            Item = new HashSet<Item>();
        }

        public int Id { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public int? OwnerUserId { get; set; }

        public int CreatedByUserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UniqueId { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }

        [StringLength(2000)]
        public string BrandDesc { get; set; }

        [Required]
        [StringLength(200)]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item { get; set; }
    }
}
