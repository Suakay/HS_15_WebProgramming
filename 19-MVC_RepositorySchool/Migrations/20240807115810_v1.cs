using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_MVC_RepositorySchool.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Okullar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulID = table.Column<int>(type: "int", nullable: false),
                    OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OkulAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OkulTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OkulEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OkulKuruluşTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okullar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    OgrenciAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OgrenciSinifi = table.Column<byte>(type: "tinyint", nullable: false),
                    OgrenciAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciVeliTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgrenciOkulu = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Okullar_OgrenciOkulu",
                        column: x => x.OgrenciOkulu,
                        principalTable: "Okullar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_OgrenciOkulu",
                table: "Ogrenciler",
                column: "OgrenciOkulu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Okullar");
        }
    }
}
