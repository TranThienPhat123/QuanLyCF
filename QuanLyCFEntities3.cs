using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanCafe2
{
    public partial class QuanLyCFEntities3 : DbContext
    {
        public QuanLyCFEntities3()
            : base("name=QuanLyCFEntities31")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<BanSanPham> BanSanPhams { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.BanSanPhams)
                .WithOptional(e => e.Ban)
                .HasForeignKey(e => e.BanId);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.BanSanPhams1)
                .WithOptional(e => e.Ban1)
                .HasForeignKey(e => e.BanId);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.BanSanPhams)
                .WithOptional(e => e.SanPham)
                .HasForeignKey(e => e.SanPhamId);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.BanSanPhams1)
                .WithOptional(e => e.SanPham1)
                .HasForeignKey(e => e.SanPhamId);
        }
    }
}
