using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookItem_BookTitles_BookTitleId",
                table: "BookItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookItem_LoanBookId",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookItem",
                table: "BookItem");

            migrationBuilder.RenameTable(
                name: "BookItem",
                newName: "BookItems");

            migrationBuilder.RenameIndex(
                name: "IX_BookItem_BookTitleId",
                table: "BookItems",
                newName: "IX_BookItems_BookTitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookItems",
                table: "BookItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems",
                column: "BookTitleId",
                principalTable: "BookTitles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookItems_LoanBookId",
                table: "Loans",
                column: "LoanBookId",
                principalTable: "BookItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookItems_LoanBookId",
                table: "Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookItems",
                table: "BookItems");

            migrationBuilder.RenameTable(
                name: "BookItems",
                newName: "BookItem");

            migrationBuilder.RenameIndex(
                name: "IX_BookItems_BookTitleId",
                table: "BookItem",
                newName: "IX_BookItem_BookTitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookItem",
                table: "BookItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookItem_BookTitles_BookTitleId",
                table: "BookItem",
                column: "BookTitleId",
                principalTable: "BookTitles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookItem_LoanBookId",
                table: "Loans",
                column: "LoanBookId",
                principalTable: "BookItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
