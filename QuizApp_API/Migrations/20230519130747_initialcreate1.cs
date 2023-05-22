using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp_API.Migrations
{
    public partial class initialcreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "quiz_Attempts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizMarks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quiz_Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionsPerPage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingCriteriaInPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quiz_Attempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_quiz_Attempts_User_Admins_UserId",
                        column: x => x.UserId,
                        principalTable: "User_Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "quizQuestions_Attempts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    Marks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplexityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quizQuestions_Attempts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_quizQuestions_Attempts_quiz_Attempts_QuizId",
                        column: x => x.QuizId,
                        principalTable: "quiz_Attempts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_quiz_Attempts_UserId",
                table: "quiz_Attempts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_quizQuestions_Attempts_QuizId",
                table: "quizQuestions_Attempts",
                column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quizQuestions_Attempts");

            migrationBuilder.DropTable(
                name: "quiz_Attempts");

            migrationBuilder.DropTable(
                name: "User_Admins");
        }
    }
}
