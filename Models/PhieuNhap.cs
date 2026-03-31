using System.ComponentModel.DataAnnotations;

namespace QLKHO1.Models
{
    public class PhieuNhap
    {
        [Key]
        public string SoPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TrangThai { get; set; }
        public int MaND { get; set; }
        public List<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
