using System.ComponentModel.DataAnnotations;

namespace QLKHO1.Models
{
    public class ViTri
    {
        [Key]
        public string MaViTri { get; set; }

        public string LoaiViTri { get; set; }

        public double SucChua { get; set; }

        public double SucChuaConLai { get; set; }
    }
}
