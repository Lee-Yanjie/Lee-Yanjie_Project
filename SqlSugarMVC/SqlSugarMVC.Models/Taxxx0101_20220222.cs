namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taxxx0101_20220222
    {
        [Key]
        public Guid Pk { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime? Time { get; set; }
    }
}
