namespace SqlSugarMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUser")]
    public partial class SysUser
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public long QQ { get; set; }

        [Required]
        [StringLength(255)]
        public string WeChat { get; set; }

        public int Sex { get; set; }

        public DateTime LastLoginTime { get; set; }

        public DateTime CreateTime { get; set; }

        public int CreateId { get; set; }

        public DateTime LastModifyTime { get; set; }

        public int LastModifyId { get; set; }

        public int CompanyId { get; set; }
    }
}
