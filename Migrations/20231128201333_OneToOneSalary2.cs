using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application1.Migrations
{
    public partial class OneToOneSalary2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employee_Id",
                table: "SalaryInfo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SalaryInfo",
                newName: "SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employee_SalaryId",
                table: "SalaryInfo",
                column: "SalaryId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryInfo_Employee_SalaryId",
                table: "SalaryInfo");

            migrationBuilder.RenameColumn(
                name: "SalaryId",
                table: "SalaryInfo",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryInfo_Employee_Id",
                table: "SalaryInfo",
                column: "Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
