using Microsoft.EntityFrameworkCore;
using QLKHO1.Models;

namespace QLKHO1.Data
{
    public class PhieuNhapDbContext : DbContext
    {
        public PhieuNhapDbContext(DbContextOptions<PhieuNhapDbContext> options) : base(options)
        {
        }
        public DbSet<VatTu> VatTus { get; set; }
        public DbSet<ViTri> ViTris { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
