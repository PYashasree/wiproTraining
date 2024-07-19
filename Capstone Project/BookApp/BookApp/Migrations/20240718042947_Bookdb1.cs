using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookServices.Migrations
{
    /// <inheritdoc />
    public partial class Bookdb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "biography",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "biography",
                table: "Authors");
        }
    }
}
