namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vCategory")]
    public partial class vCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vCategory()
        {
        }

        public int Id { get; set; }

        public bool Active { get; set; }

        public int? ParentId { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(100)]
        public string Category1 { get; set; }

        public int UserId { get; set; }

        public string Crumb { get; set; }
    }
}
