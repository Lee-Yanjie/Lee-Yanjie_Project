namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? ParentId { get; set; }

        public DateTime? Createtime { get; set; }

        public DateTime? ModifyTime { get; set; }
    }
}
