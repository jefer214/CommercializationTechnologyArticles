namespace CommercializationTechnologyArticles.Data
{
    using CommercializationTechnologyArticles.Models;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;

    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<SubCategoriesInCategory> SubCategoriesInCategories { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticlesInCategory> ArticlesInCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("PK_Category");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId).HasName("PK_SubCategory");

                entity.Property(e => e.SubCategoryId).ValueGeneratedNever();
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Article");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ArticlesInCategory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SubCategoriesInCategory>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

