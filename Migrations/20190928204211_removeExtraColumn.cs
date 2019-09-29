using Microsoft.EntityFrameworkCore.Migrations;

namespace sdgreacttemplate.Migrations
{
    public partial class removeExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_Questionsid",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "Questionsid",
                table: "Answers",
                newName: "QuestionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_Questionsid",
                table: "Answers",
                newName: "IX_Answers_QuestionsId");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionsId",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionsId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "QuestionsId",
                table: "Answers",
                newName: "Questionsid");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_QuestionsId",
                table: "Answers",
                newName: "IX_Answers_Questionsid");

            migrationBuilder.AlterColumn<int>(
                name: "Questionsid",
                table: "Answers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_Questionsid",
                table: "Answers",
                column: "Questionsid",
                principalTable: "Questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
