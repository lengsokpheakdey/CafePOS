using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CafePOS.API.Models
{
    public partial class CafePOSContext : DbContext
    {
        public CafePOSContext()
        {
        }

        public CafePOSContext(DbContextOptions<CafePOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<MainCategory> MainCategory { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuPrice> MenuPrice { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleControl> RoleControl { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleDetail> SaleDetail { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=CafePOS; User Id =sa; Password=\"$uP3RC0mpl3Xp@$$w0rD\"");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameKh).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<MainCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MainCategory)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MainCategory_Status");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MenuCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .HasConstraintName("FK_Menu_User");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Menu_Status");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.SubId)
                    .HasConstraintName("FK_Menu_SubCategory");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MenuUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .HasConstraintName("FK_Menu_User1");
            });

            modelBuilder.Entity<MenuPrice>(entity =>
            {
                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuPrice)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_MenuPrice_Menu");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.MenuPrice)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_MenuPrice_Size");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_Payment_Sale");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Payment_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<RoleControl>(entity =>
            {
                entity.HasOne(d => d.Control)
                    .WithMany(p => p.RoleControl)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_RoleControl_Control");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleControl)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleControl_Role");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Sale_User");
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductSize).HasMaxLength(50);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDetail)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleDetail_Sale");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MainCategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.MainCategory)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.MainCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategory_MainCategory");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SubCategory_Status");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_User_Status");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_User");
            });
        }
    }
}
