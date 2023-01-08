using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_designations_DesignationId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DesignationId1",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_designations",
                table: "designations");

            migrationBuilder.DropColumn(
                name: "DesignationId1",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "designations",
                newName: "Designations");

            migrationBuilder.AlterColumn<int>(
                name: "DesignationId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImagePath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationId",
                table: "Employees",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DesignationId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "ProfileImagePath",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "designations");

            migrationBuilder.AlterColumn<string>(
                name: "DesignationId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DesignationId1",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_designations",
                table: "designations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationId1",
                table: "Employees",
                column: "DesignationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_designations_DesignationId1",
                table: "Employees",
                column: "DesignationId1",
                principalTable: "designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
