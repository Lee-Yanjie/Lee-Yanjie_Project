namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserDescription")]
    public partial class UserDescription
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [StringLength(20)]
        public string UerName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
