using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RENTACAR.Migrations
{
    /// <inheritdoc />
    public partial class WorkshiftAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkingShift",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingShift",
                table: "ContactInfos");
        }
    }
}
