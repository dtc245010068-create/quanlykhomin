using System.ComponentModel.DataAnnotations;

namespace QLKHO1.Models
{
    public class VatTu
    {
        [Key]
        public string MaVatTu { get; set; }

        [Required]
        public string TenVatTu { get; set; }

        public double DonGia { get; set; }

        public int SoLuongTon { get; set; }

        public int DinhMucTon { get; set; }
    }
}
