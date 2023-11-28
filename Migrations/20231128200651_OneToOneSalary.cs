using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application1.Migrations
{
    public partial class OneToOneSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SalaryInfo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                name: "FK_SalaryInfo_Employee_Id",
                table: "SalaryInfo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SalaryInfo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
