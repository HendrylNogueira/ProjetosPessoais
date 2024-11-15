using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectInlog.Migrations
{
    public partial class AddNumeroDePassageiros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "NumeroPassageiros",
                table: "Veiculos",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroPassageiros",
                table: "Veiculos");
        }
    }
}
