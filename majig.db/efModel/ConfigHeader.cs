namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigHeader")]
    public partial class ConfigHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfigHeader()
        {
            ConfigDetail = new HashSet<ConfigDetail>();
            Item = new HashSet<Item>();
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
        public string ConfigName { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [Required]
        [StringLength(50)]
        public string ConfigType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigDetail> ConfigDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item { get; set; }
    }
}
