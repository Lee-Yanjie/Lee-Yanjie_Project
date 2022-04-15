namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogicTest")]
    public partial class LogicTest
    {
        public int Id { get; set; }

        public bool isdeleted { get; set; }
    }
}
