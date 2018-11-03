namespace majig.db.ef
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MajigContext : DbContext
    {
        public MajigContext() : base("name=majigDb") { }

        public virtual DbSet<C_ChangeLog> C_ChangeLog { get; set; }
        public virtual DbSet<C_Role> C_Role { get; set; }
        public virtual DbSet<C_UserClaim> C_UserClaim { get; set; }
        public virtual DbSet<C_UserLogin> C_UserLogin { get; set; }
        public virtual DbSet<C_Users> C_Users { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BuildDetail> BuildDetail { get; set; }
        public virtual DbSet<BuildHeader> BuildHeader { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CompatDetail> CompatDetail { get; set; }
        public virtual DbSet<CompatHeader> CompatHeader { get; set; }
        public virtual DbSet<ConfigDetail> ConfigDetail { get; set; }
        public virtual DbSet<ConfigHeader> ConfigHeader { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<vCompat> vCompat { get; set; }
        public virtual DbSet<vConfig> vConfig { get; set; }
        public virtual DbSet<vItems> vItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_ChangeLog>()
                .Property(e => e.SourceTable)
                .IsUnicode(false);

            modelBuilder.Entity<C_Role>()
                .HasMany(e => e.C_Users)
                .WithMany(e => e.C_Role)
                .Map(m => m.ToTable("_UserRole").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<C_Users>()
                .HasMany(e => e.C_UserClaim)
                .WithRequired(e => e.C_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<C_Users>()
                .HasMany(e => e.C_UserLogin)
                .WithRequired(e => e.C_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Asset>()
                .Property(e => e.ItemSource)
                .IsUnicode(false);

            modelBuilder.Entity<Asset>()
                .Property(e => e.ItemDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Asset>()
                .Property(e => e.AssetName)
                .IsUnicode(false);

            modelBuilder.Entity<Asset>()
                .Property(e => e.AssetType)
                .IsUnicode(false);

            modelBuilder.Entity<BuildHeader>()
                .HasMany(e => e.BuildDetail)
                .WithRequired(e => e.BuildHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category11)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<CompatHeader>()
                .HasMany(e => e.CompatDetail)
                .WithRequired(e => e.CompatHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConfigHeader>()
                .HasMany(e => e.ConfigDetail)
                .WithRequired(e => e.ConfigHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.CompatDetail)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Item1)
                .WithOptional(e => e.Item2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<vCompat>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vItems>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
