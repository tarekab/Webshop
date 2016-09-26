namespace WU15.AlltOchMer.Web.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DefaultDataContext : DbContext
    {
        public DefaultDataContext()
            : base("name=DefaultDataContext7")
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartProduct> CartProduct { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryName> CategoryName { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductPriceList> ProductPriceList { get; set; }
        public virtual DbSet<supplier> supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<VAT> VAT { get; set; }
        public virtual DbSet<CartProductSweden> CartProductSweden { get; set; }
        public virtual DbSet<cartSweden> cartSweden { get; set; }
        public virtual DbSet<DanishMainCategory> DanishMainCategory { get; set; }
        public virtual DbSet<FinnishMainCategory> FinnishMainCategory { get; set; }
        public virtual DbSet<MainCategoryDanmark> MainCategoryDanmark { get; set; }
        public virtual DbSet<MainCategoryNorway> MainCategoryNorway { get; set; }
        public virtual DbSet<MainCategorySweden> MainCategorySweden { get; set; }
        public virtual DbSet<NorwegianMainCategory> NorwegianMainCategory { get; set; }
        public virtual DbSet<ProductDk> ProductDk { get; set; }
        public virtual DbSet<ProductNo> ProductNo { get; set; }
        public virtual DbSet<ProductSe> ProductSe { get; set; }
        public virtual DbSet<ProductRandomSe> ProductRandomSe { get; set; }
        public virtual DbSet<Subcategories> Subcategories { get; set; }
        public virtual DbSet<SwedishMainCategory> SwedishMainCategory { get; set; }
        public virtual DbSet<SwedishSubcategory> SwedishSubcategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartProduct>()
                .Property(e => e.Pris)
                .HasPrecision(7, 0);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryName)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.Category_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.ProductCategory)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(3, 2);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.CategoryName)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.ProductDescription)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<PriceList>()
                .HasMany(e => e.ProductPriceList)
                .WithRequired(e => e.PriceList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDescription)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductPriceList)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.supplier)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("ProductSupplier").MapLeftKey("ProductId").MapRightKey("SupplierId"));

            modelBuilder.Entity<Product>()
                .HasMany(e => e.VAT)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("VATProduct").MapLeftKey("ProductId").MapRightKey("VATId"));

            modelBuilder.Entity<ProductPriceList>()
                .Property(e => e.Price)
                .HasPrecision(7, 0);

            modelBuilder.Entity<VAT>()
                .Property(e => e.VAT1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<CartProductSweden>()
                .Property(e => e.Pris)
                .HasPrecision(7, 0);

            modelBuilder.Entity<cartSweden>()
                .Property(e => e.Pris)
                .HasPrecision(7, 0);

            modelBuilder.Entity<MainCategoryDanmark>()
                .Property(e => e.Price)
                .HasPrecision(7, 0);

            modelBuilder.Entity<MainCategoryDanmark>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(3, 2);

            modelBuilder.Entity<MainCategoryDanmark>()
                .Property(e => e.VAT)
                .HasPrecision(4, 2);

            modelBuilder.Entity<MainCategoryNorway>()
                .Property(e => e.Price)
                .HasPrecision(7, 0);

            modelBuilder.Entity<MainCategoryNorway>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(3, 2);

            modelBuilder.Entity<MainCategoryNorway>()
                .Property(e => e.VAT)
                .HasPrecision(4, 2);

            modelBuilder.Entity<MainCategorySweden>()
                .Property(e => e.Price)
                .HasPrecision(7, 0);

            modelBuilder.Entity<MainCategorySweden>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(3, 2);

            modelBuilder.Entity<MainCategorySweden>()
                .Property(e => e.VAT)
                .HasPrecision(4, 2);

            modelBuilder.Entity<ProductSe>()
                .Property(e => e.Price)
                .HasPrecision(7, 0);

        
    }
       
    }

}
