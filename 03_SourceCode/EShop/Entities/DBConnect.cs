namespace WebDemo.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnect : DbContext
    {
        public DBConnect()
            : base("name=DBConnect3")
        {
        }

        public virtual DbSet<ChildCategory> ChildCategories { get; set; }
        public virtual DbSet<ImageManufactory> ImageManufactories { get; set; }
        public virtual DbSet<ImageSlidePriCategory> ImageSlidePriCategories { get; set; }
        public virtual DbSet<Manufactory> Manufactories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<PriCategory> PriCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductFollowAge> ProductFollowAges { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<RelaChildSubCategory> RelaChildSubCategories { get; set; }
        public virtual DbSet<RelaPriSubCategory> RelaPriSubCategories { get; set; }
        public virtual DbSet<RoleDetail> RoleDetails { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChildCategory>()
                .HasMany(e => e.RelaChildSubCategories)
                .WithRequired(e => e.ChildCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChildCategory>()
                .HasMany(e => e.Products)
                .WithMany(e => e.ChildCategories)
                .Map(m => m.ToTable("RelaProductSubCategories").MapLeftKey("ChildCategoriesID").MapRightKey("ProductId"));

            modelBuilder.Entity<ImageManufactory>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<ImageSlidePriCategory>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderDetailID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Password>()
                .Property(e => e.PasswordSalt)
                .IsUnicode(false);

            modelBuilder.Entity<PriCategory>()
                .Property(e => e.PriCategoriesImages)
                .IsUnicode(false);

            modelBuilder.Entity<PriCategory>()
                .HasMany(e => e.ImageSlidePriCategories)
                .WithRequired(e => e.PriCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriCategory>()
                .HasMany(e => e.RelaPriSubCategories)
                .WithRequired(e => e.PriCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductDecription)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductImages)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductFollowAge>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<ProductImage>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<RoleDetail>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<RoleDetail>()
                .HasMany(e => e.Users)
                .WithMany(e => e.RoleDetails)
                .Map(m => m.ToTable("Role").MapLeftKey("RoleID").MapRightKey("UserID"));

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.RelaChildSubCategories)
                .WithRequired(e => e.SubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.RelaPriSubCategories)
                .WithRequired(e => e.SubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
