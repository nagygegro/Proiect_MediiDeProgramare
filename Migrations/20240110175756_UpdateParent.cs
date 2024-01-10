using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class UpdateParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentStudent");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Parent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parent_StudentId",
                table: "Parent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parent_Student_StudentId",
                table: "Parent",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parent_Student_StudentId",
                table: "Parent");

            migrationBuilder.DropIndex(
                name: "IX_Parent_StudentId",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Parent");

            migrationBuilder.CreateTable(
                name: "ParentStudent",
                columns: table => new
                {
                    ParentsID = table.Column<int>(type: "int", nullable: false),
                    StudentsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentStudent", x => new { x.ParentsID, x.StudentsID });
                    table.ForeignKey(
                        name: "FK_ParentStudent_Parent_ParentsID",
                        column: x => x.ParentsID,
                        principalTable: "Parent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentStudent_Student_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentStudent_StudentsID",
                table: "ParentStudent",
                column: "StudentsID");
        }
    }
}
