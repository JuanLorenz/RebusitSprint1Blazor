using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class MakeCommentsAndRatingsAppLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Goals_GoalId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Goals_GoalId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_GoalId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Comments_GoalId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "Ratings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_GoalId",
                table: "Ratings",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GoalId",
                table: "Comments",
                column: "GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Goals_GoalId",
                table: "Comments",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Goals_GoalId",
                table: "Ratings",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
