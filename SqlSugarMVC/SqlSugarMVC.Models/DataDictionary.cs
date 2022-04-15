namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataDictionary")]
    public partial class DataDictionary
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Type { get; set; }
    }
}
