using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.Web.Migrations
{
    /// <inheritdoc />
    public partial class RelateEmpDeg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Designation",
                table: "Employees",
                newName: "DesignationId");

            migrationBuilder.AddColumn<int>(
                name: "DesignationId1",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_designations_DesignationId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DesignationId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DesignationId1",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "Employees",
                newName: "Designation");
        }
    }
}
