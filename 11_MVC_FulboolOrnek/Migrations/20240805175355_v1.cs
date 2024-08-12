using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _11_MVC_FulboolOrnek.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MevkiID",
                table: "Futbolcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TakimID",
                table: "Futbolcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yas",
                table: "Futbolcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcu_MevkiID",
                table: "Futbolcu",
                column: "MevkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcu_TakimID",
                table: "Futbolcu",
                column: "TakimID");

            migrationBuilder.AddForeignKey(
                name: "FK_Futbolcu_Mevki_MevkiID",
                table: "Futbolcu",
                column: "MevkiID",
                principalTable: "Mevki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Futbolcu_Takim_TakimID",
                table: "Futbolcu",
                column: "TakimID",
                principalTable: "Takim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Futbolcu_Mevki_MevkiID",
                table: "Futbolcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Futbolcu_Takim_TakimID",
                table: "Futbolcu");

            migrationBuilder.DropIndex(
                name: "IX_Futbolcu_MevkiID",
                table: "Futbolcu");

            migrationBuilder.DropIndex(
                name: "IX_Futbolcu_TakimID",
                table: "Futbolcu");

            migrationBuilder.DropColumn(
                name: "MevkiID",
                table: "Futbolcu");

            migrationBuilder.DropColumn(
                name: "TakimID",
                table: "Futbolcu");

            migrationBuilder.DropColumn(
                name: "Yas",
                table: "Futbolcu");
        }
    }
}
