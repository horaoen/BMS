using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class modifybookitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "Loans",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "BookTitleId",
                table: "BookItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "BookTitles",
                columns: new[] { "Id", "Author", "BorrowedNumber", "Name", "Revations", "TotalNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), "Eric Evans", 0, "领域驱动设计", 0, 19, null },
                    { new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), "Ddrew Neil", 0, "Vim实用技巧", 0, 20, null },
                    { new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), "吴建", 0, "UML基础与Rose建模案例", 0, 30, null },
                    { new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), "张嘉佳", 0, "云边有个小卖铺", 0, 90, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems",
                column: "BookTitleId",
                principalTable: "BookTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems");

            migrationBuilder.DeleteData(
                table: "BookTitles",
                keyColumn: "Id",
                keyValue: new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"));

            migrationBuilder.DeleteData(
                table: "BookTitles",
                keyColumn: "Id",
                keyValue: new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"));

            migrationBuilder.DeleteData(
                table: "BookTitles",
                keyColumn: "Id",
                keyValue: new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"));

            migrationBuilder.DeleteData(
                table: "BookTitles",
                keyColumn: "Id",
                keyValue: new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "Loans",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "BookTitleId",
                table: "BookItems",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_BookItems_BookTitles_BookTitleId",
                table: "BookItems",
                column: "BookTitleId",
                principalTable: "BookTitles",
                principalColumn: "Id");
        }
    }
}
