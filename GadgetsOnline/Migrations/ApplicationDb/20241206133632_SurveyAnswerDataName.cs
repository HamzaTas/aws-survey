using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GadgetsOnline.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class SurveyAnswerDataName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "SurveyAnswerData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyAnswerData",
                table: "SurveyAnswerData",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyAnswerData",
                table: "SurveyAnswerData");

            migrationBuilder.RenameTable(
                name: "SurveyAnswerData",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
