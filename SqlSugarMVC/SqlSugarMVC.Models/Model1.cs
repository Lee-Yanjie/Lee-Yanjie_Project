using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SqlSugarMVC.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<A> A { get; set; }
        public virtual DbSet<ABMapping> ABMapping { get; set; }
        public virtual DbSet<B> B { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<City1> City1 { get; set; }
        public virtual DbSet<CodeFirstTable1> CodeFirstTable1 { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Country1> Country1 { get; set; }
        public virtual DbSet<LogicTest> LogicTest { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigrequest> MSpeer_conflictdetectionconfigrequest { get; set; }
        public virtual DbSet<MSpeer_lsns> MSpeer_lsns { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Province1> Province1 { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RootTable0> RootTable0 { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<sysreplservers> sysreplservers { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<SysUserRoleMap> SysUserRoleMap { get; set; }
        public virtual DbSet<Taxxx0101_17530101> Taxxx0101_17530101 { get; set; }
        public virtual DbSet<Taxxx0101_20210423> Taxxx0101_20210423 { get; set; }
        public virtual DbSet<Taxxx0101_20220222> Taxxx0101_20220222 { get; set; }
        public virtual DbSet<Taxxx0101_20220223> Taxxx0101_20220223 { get; set; }
        public virtual DbSet<ThreeItem2> ThreeItem2 { get; set; }
        public virtual DbSet<Tree> Tree { get; set; }
        public virtual DbSet<TwoItem> TwoItem { get; set; }
        public virtual DbSet<TwoItem2> TwoItem2 { get; set; }
        public virtual DbSet<TwoItem3> TwoItem3 { get; set; }
        public virtual DbSet<UserDescription> UserDescription { get; set; }
        public virtual DbSet<ZhaoxiInfo> ZhaoxiInfo { get; set; }
        public virtual DbSet<Custom> Custom { get; set; }
        public virtual DbSet<DataDictionary> DataDictionary { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigresponse> MSpeer_conflictdetectionconfigresponse { get; set; }
        public virtual DbSet<MSpeer_originatorid_history> MSpeer_originatorid_history { get; set; }
        public virtual DbSet<MSpeer_request> MSpeer_request { get; set; }
        public virtual DbSet<MSpeer_response> MSpeer_response { get; set; }
        public virtual DbSet<MSpeer_topologyrequest> MSpeer_topologyrequest { get; set; }
        public virtual DbSet<MSpeer_topologyresponse> MSpeer_topologyresponse { get; set; }
        public virtual DbSet<MSpub_identity_range> MSpub_identity_range { get; set; }
        public virtual DbSet<sysarticlecolumns> sysarticlecolumns { get; set; }
        public virtual DbSet<sysarticles> sysarticles { get; set; }
        public virtual DbSet<sysarticleupdates> sysarticleupdates { get; set; }
        public virtual DbSet<syspublications> syspublications { get; set; }
        public virtual DbSet<sysschemaarticles> sysschemaarticles { get; set; }
        public virtual DbSet<syssubscriptions> syssubscriptions { get; set; }
        public virtual DbSet<systranschemas> systranschemas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<B>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CodeFirstTable1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CodeFirstTable1>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Commodity>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Commodity>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Commodity>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Province1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RootTable0>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SysRole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.WeChat)
                .IsUnicode(false);

            modelBuilder.Entity<Taxxx0101_17530101>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Taxxx0101_20210423>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Taxxx0101_20220222>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Taxxx0101_20220223>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ThreeItem2>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ThreeItem2>()
                .Property(e => e.TwoItem2Id)
                .IsUnicode(false);

            modelBuilder.Entity<Tree>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TwoItem>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TwoItem2>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<TwoItem3>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TwoItem3>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<UserDescription>()
                .Property(e => e.UerName)
                .IsUnicode(false);

            modelBuilder.Entity<UserDescription>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Custom>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DataDictionary>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<DataDictionary>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DataDictionary>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<sysarticles>()
                .Property(e => e.schema_option)
                .IsFixedLength();

            modelBuilder.Entity<syspublications>()
                .Property(e => e.snapshot_jobid)
                .IsFixedLength();

            modelBuilder.Entity<syspublications>()
                .Property(e => e.min_autonosync_lsn)
                .IsFixedLength();

            modelBuilder.Entity<sysschemaarticles>()
                .Property(e => e.schema_option)
                .IsFixedLength();

            modelBuilder.Entity<syssubscriptions>()
                .Property(e => e.distribution_jobid)
                .IsFixedLength();

            modelBuilder.Entity<syssubscriptions>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<systranschemas>()
                .Property(e => e.startlsn)
                .IsFixedLength();

            modelBuilder.Entity<systranschemas>()
                .Property(e => e.endlsn)
                .IsFixedLength();
        }
    }
}
