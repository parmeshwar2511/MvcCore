using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Code_First_Approch.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MONO",
                table: "categories",
                newName: "Number");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "categories",
                newName: "MONO");
        }
    }
}
