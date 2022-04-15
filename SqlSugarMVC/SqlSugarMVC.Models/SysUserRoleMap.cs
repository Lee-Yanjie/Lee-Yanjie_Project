namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUserRoleMap")]
    public partial class SysUserRoleMap
    {
        public int Id { get; set; }

        public int? RoleId { get; set; }

        public int? UserId { get; set; }
    }
}
