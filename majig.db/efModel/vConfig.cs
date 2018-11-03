namespace majig.db.ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vConfig")]
    public partial class vConfig
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ConfigUniqueId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ConfigName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ConfigType { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigDetailId { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsRequired { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatGroupId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string CatGroup { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string Category { get; set; }
    }
}
