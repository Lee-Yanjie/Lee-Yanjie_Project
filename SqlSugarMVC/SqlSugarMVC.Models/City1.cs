namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class City1
    {
        public int Id { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
