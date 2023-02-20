using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktinis_Baigiamasis_Darbas.Migrations
{
    /// <inheritdoc />
    public partial class test12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Locations_LocationID",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Locations_LocationID",
                table: "Persons",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Locations_LocationID",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Locations_LocationID",
                table: "Persons",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
