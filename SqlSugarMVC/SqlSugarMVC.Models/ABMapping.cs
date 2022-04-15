namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABMapping")]
    public partial class ABMapping
    {
        [Key]
        public int AId { get; set; }

        public int BId { get; set; }
    }
}
