namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        public int ItemId { get; set; }

        public int OrderId { get; set; }

        public decimal Price { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
