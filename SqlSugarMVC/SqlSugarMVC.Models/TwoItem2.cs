namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TwoItem2
    {
        [StringLength(255)]
        public string Id { get; set; }

        public int RootId { get; set; }
    }
}
