namespace majig.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildHeader")]
    public partial class BuildHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildHeader()
        {
            BuildDetail = new HashSet<BuildDetail>();
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
        public string BuildName { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [Required]
        [StringLength(100)]
        public string BuilderEmail { get; set; }

        [StringLength(200)]
        public string BuildExtUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildDetail> BuildDetail { get; set; }
    }
}
