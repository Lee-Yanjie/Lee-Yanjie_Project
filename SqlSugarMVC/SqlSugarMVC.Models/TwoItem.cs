namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TwoItem")]
    public partial class TwoItem
    {
        public int Id { get; set; }

        public int RootId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
