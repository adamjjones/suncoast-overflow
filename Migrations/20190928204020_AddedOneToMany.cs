using Microsoft.EntityFrameworkCore.Migrations;

namespace sdgreacttemplate.Migrations
{
    public partial class AddedOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Questionsid",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Questionsid",
                table: "Answers",
                column: "Questionsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_Questionsid",
                table: "Answers",
                column: "Questionsid",
                principalTable: "Questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_Questionsid",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_Questionsid",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Questionsid",
                table: "Answers");
        }
    }
}
