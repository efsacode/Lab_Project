using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application1.Migrations
{
    public partial class FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employee_SalaryId",
                table: "SalaryInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo");

            migrationBuilder.RenameColumn(
                name: "SalaryId",
                table: "SalaryInfo",
                newName: "EmployeeIdId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SalaryInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryInfo_EmployeeIdId",
                table: "SalaryInfo",
                column: "EmployeeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employee_EmployeeIdId",
                table: "SalaryInfo",
                column: "EmployeeIdId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employee_Id",
                table: "SalaryInfo",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employee_EmployeeIdId",
                table: "SalaryInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employee_Id",
                table: "SalaryInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo");

            migrationBuilder.DropIndex(
                name: "IX_SalaryInfo_EmployeeIdId",
                table: "SalaryInfo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SalaryInfo");

            migrationBuilder.RenameColumn(
                name: "EmployeeIdId",
                table: "SalaryInfo",
                newName: "SalaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalaryInfo",
                table: "SalaryInfo",
                column: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employee_SalaryId",
                table: "SalaryInfo",
                column: "SalaryId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
