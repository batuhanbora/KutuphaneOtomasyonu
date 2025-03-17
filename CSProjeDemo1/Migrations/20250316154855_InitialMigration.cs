using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSProjeDemo1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    UyeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.UyeNo);
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YayinYili = table.Column<int>(type: "int", nullable: false),
                    KitapDurumu = table.Column<int>(type: "int", nullable: false),
                    UyeNo = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitap_Uyeler_UyeNo",
                        column: x => x.UyeNo,
                        principalTable: "Uyeler",
                        principalColumn: "UyeNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_UyeNo",
                table: "Kitap",
                column: "UyeNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Uyeler");
        }
    }
}
