using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktinis_Baigiamasis_Darbas.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Locations_LocationId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Users",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                newName: "IX_Users_PersonID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Persons",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_LocationId",
                table: "Persons",
                newName: "IX_Persons_LocationID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Locations_LocationID",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Users",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PersonID",
                table: "Users",
                newName: "IX_Users_PersonId");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Persons",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_LocationID",
                table: "Persons",
                newName: "IX_Persons_LocationId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Locations_LocationId",
                table: "Persons",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
