using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLKHO1.Migrations
{
    /// <inheritdoc />
    public partial class qlkho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhieuNhaps",
                columns: table => new
                {
                    SoPhieuNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaND = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhaps", x => x.SoPhieuNhap);
                });

            migrationBuilder.CreateTable(
                name: "VatTus",
                columns: table => new
                {
                    MaVatTu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenVatTu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    DinhMucTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTus", x => x.MaVatTu);
                });

            migrationBuilder.CreateTable(
                name: "ViTris",
                columns: table => new
                {
                    MaViTri = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<double>(type: "float", nullable: false),
                    SucChuaConLai = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViTris", x => x.MaViTri);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoPhieuNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhieuNhapSoPhieuNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaVatTu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatTuMaVatTu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhaps_PhieuNhaps_PhieuNhapSoPhieuNhap",
                        column: x => x.PhieuNhapSoPhieuNhap,
                        principalTable: "PhieuNhaps",
                        principalColumn: "SoPhieuNhap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhaps_VatTus_VatTuMaVatTu",
                        column: x => x.VatTuMaVatTu,
                        principalTable: "VatTus",
                        principalColumn: "MaVatTu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhaps_PhieuNhapSoPhieuNhap",
                table: "ChiTietPhieuNhaps",
                column: "PhieuNhapSoPhieuNhap");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhaps_VatTuMaVatTu",
                table: "ChiTietPhieuNhaps",
                column: "VatTuMaVatTu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhaps");

            migrationBuilder.DropTable(
                name: "ViTris");

            migrationBuilder.DropTable(
                name: "PhieuNhaps");

            migrationBuilder.DropTable(
                name: "VatTus");
        }
    }
}
