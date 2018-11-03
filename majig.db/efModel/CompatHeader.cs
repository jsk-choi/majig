namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompatHeader")]
    public partial class CompatHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompatHeader()
        {
            CompatDetail = new HashSet<CompatDetail>();
        }

        public int Id { get; set; }

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UniqueId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompatName { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompatDetail> CompatDetail { get; set; }
    }
}
