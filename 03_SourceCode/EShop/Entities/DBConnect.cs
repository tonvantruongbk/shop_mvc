namespace WebDemo.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnect : DbContext
    {
        public DBConnect()
            : base("name=DBConnect")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ImageSlideCategory> ImageSlideCategories { get; set; }
        public virtual DbSet<Manufactory> Manufactories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductFollowAge> ProductFollowAges { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<RoleDetail> RoleDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoriesImages)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.ImageSlideCategories)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoriesID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CategoriesID);

            modelBuilder.Entity<ImageSlideCategory>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Manufactory>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Manufactories)
                .Map(m => m.ToTable("ManufactoriesCategories").MapLeftKey("ManufactoriesID").MapRightKey("CategoriesID"));

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
