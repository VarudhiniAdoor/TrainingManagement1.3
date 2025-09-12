using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManagement1.Migrations
{
    /// <inheritdoc />
    public partial class enrolcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Users_UserId",
                table: "Enrollment");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Users_UserId",
                table: "Enrollment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Users_UserId",
                table: "Enrollment");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Users_UserId",
                table: "Enrollment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
