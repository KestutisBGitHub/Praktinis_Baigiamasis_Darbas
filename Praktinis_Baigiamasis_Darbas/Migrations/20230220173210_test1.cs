using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktinis_Baigiamasis_Darbas.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_LocationId",
                table: "Persons",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Locations_LocationId",
                table: "Persons",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Locations_LocationId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_LocationId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Persons");
        }
    }
}
