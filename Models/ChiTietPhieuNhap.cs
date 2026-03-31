namespace QLKHO1.Models
{
    public class ChiTietPhieuNhap
    {
        public int Id { get; set; }

        public string SoPhieuNhap { get; set; }
        public PhieuNhap PhieuNhap { get; set; }

        public string MaVatTu { get; set; }
        public VatTu VatTu { get; set; }

        public string MaViTri { get; set; }

        public int SoLuong { get; set; }
    }
}
