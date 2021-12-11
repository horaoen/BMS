using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookItems_LoanBookId",
                table: "Loans");

            migrationBuilder.DropTable(
                name: "BookItems");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookTitles",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BookTitles",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookTitleItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookTitleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsBorrowed = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTitleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookTitleItems_BookTitles_BookTitleId",
                        column: x => x.BookTitleId,
                        principalTable: "BookTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BookTitleItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("00fc0622-2427-406d-9fb3-1add3cfaab3e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("04e8a901-40ff-4efa-9743-d70011162775"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("05176841-1169-49c1-823b-72161b825d28"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("051b9c47-2ff2-475d-b7d4-2cfb89b745ad"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("09482809-d076-4cc8-b64a-505b934de6f0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("0a8d828f-3652-4101-83f9-93af566c3afe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0b8ee311-9f5d-43f9-b647-bbfda91a8f75"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0ccb7576-c20a-4ca2-a382-2eca4ba8cca5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0f7d6c25-5813-4667-aa1c-ce99a217b943"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1149e19a-a95e-457f-85e5-6afa0e7f0cab"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("11c867ef-a6e7-4c1c-ad5e-819a92c8f95f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("12d7bc98-300f-4584-a569-5ee14e420733"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("12f008de-f54a-4ea3-87d6-da2f1f85a1f3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("13180dbe-1824-4f06-960b-c6d20bb24719"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("152f0562-407e-41b5-80eb-fcb84ab5fee5"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("173b274b-93a2-4fc9-b3e0-309d410853f0"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1938c258-66a9-4fb9-8749-e6897a94fad9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("193d8e66-0bdd-4f47-be99-1894640549a3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1b62724b-a3a4-4dfd-938b-0e956c1eb638"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1c96cf4f-54de-4e74-8578-3e480b0d69f5"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("1cb250c1-6bff-4e56-8647-014775dc8e00"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1fec1f37-2134-40c6-b38a-a1f85bde048d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("211144f0-8e9d-4564-a612-7415d34df1d9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("21651a41-63bd-4cef-b8bb-6e81ed91ea99"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("21ddb979-6688-4127-bfc7-a84c449a0ea9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("237eaddc-c93f-476b-be0d-c6897e87dd06"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("250e7fcd-b8d0-4939-b701-04409efc2d29"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("25aafd0d-5be6-43f9-84c2-b8840a1c7e10"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("25e447e5-da03-403a-af4d-0889b078a9fe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("26960c50-d8e8-4a07-9199-8eca5531ddd1"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("2775f4ba-3382-47ea-969d-dbaf8a352311"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2893c980-de5d-4b9e-95e7-4891a73bca11"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2a4bd48c-ecdb-4860-8395-3d065343610e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2b06d367-a513-4632-ad15-3027fc2b9a90"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2c10e7ab-4e92-4642-8e36-115d9e55f2bf"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2f72e17f-e810-4bcd-910f-3dd6807a7fec"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2fee3f5d-aad3-4d58-aeae-38c41c8163df"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("312a0ffb-fc79-49ee-b343-a9c4e4b9bb4e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("33ab4178-d759-48ac-b7df-cf9a8fb1d1be"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("36e9c28c-c955-478f-bc3b-408795e1acc5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("39c7d1e5-04f2-4653-a503-2089fcafbe5b"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3eecdc10-6478-414d-b90f-01e532bed8b9"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("42774470-fd27-4846-8d17-f5d2fb33ee1d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4459a30a-3d7a-4f22-bc9b-9046fa7766a5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("44f6d8f7-631a-4639-bbd6-5d3e6be9cbd1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4505ba78-02f6-4222-886a-ddedde668cd2"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("47473a8d-14b8-4e45-aea1-35f07791fd5d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("489c5156-2285-4688-b613-fb7c0b87d9db"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4923a3d2-4fc5-4c13-b178-c05851909f26"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("495c2297-3cdc-4a3d-a0ac-d8f222c91458"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("4a496332-8eda-415c-be68-0c09a57e00ca"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4cc813d1-9305-496b-9a7c-3c40a950c251"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4d4eb5a4-fc69-46f1-9830-c22785cf3046"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("4e6527a5-a415-4cf6-8f62-bfd1ca482480"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("501d872e-5f50-4508-9810-f81114aa3dcb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("50b7e857-2569-4c86-9e45-186fc8b6b912"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("535d2292-a031-42e9-8a76-7608c13c6fc7"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("54419020-3d16-4a2b-88ad-1ffdcc7810c0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("54af1532-93e4-4c40-b073-dbec0bf757f5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("54ffa415-46b7-415d-b533-1aa3a40770d8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("55625207-1f0a-4e58-b01a-9e55101443e4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5ac8767a-ae2f-449f-9054-354d9a9021de"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5bd7f855-0154-424e-9f75-7fd1f76cacd0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5e52c499-108e-4c28-a2be-57de34707159"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6142c2c5-03f7-4e88-b328-04223fa03cef"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("63ed3b4c-c4ea-4694-be4f-870a9dee1633"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("65ed08d6-dc67-43e5-b593-67f74dad6da5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("660d59d2-bad0-4065-9000-e8675ce74bd2"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("669b525d-a896-44e1-9407-7f355eb8c6b8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("67b92c6f-c97b-40f8-b903-731155f02801"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("694f493d-ea68-4bab-a1e2-82a90b673bf4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("699e7378-ad2d-418d-84cf-56b960adb870"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6ade13b0-d832-44c9-a635-79416b0ce716"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6ccc0594-2d8d-412d-ad16-d33ae29dd21e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6d38f038-3c4f-4ba3-955f-2a00d2fca7d8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6d5a17a5-7b2d-4316-a1f7-7310bb44a728"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("73ffd694-56cd-4252-b23e-e63e7179efed"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7699c38a-6ee0-4a42-883b-0d7d7c6a0282"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("7ad2a24d-13ed-40de-9b44-9633120698b1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("7b45f0d7-698d-4426-9058-48299889f0c0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7d26f978-0302-4449-b538-7afd216624aa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7d4ddc8a-f705-46bf-884c-cb9188424fd4"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("7e9d83c6-adbe-44db-b9f2-d8e963f13081"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("7f73a8fe-9297-453b-a228-e6e579d76ace"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7f8f7b63-cde1-475b-8c78-c6ea7a2a8bba"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("802ab0d5-68ac-471d-8856-4ac02a47257f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("816a3d9e-a40d-4e9c-8b8d-26810c6e2d00"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("84046497-a909-42a6-913b-33efa249e1b4"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8719622c-b10d-40c9-b3de-c480aba5c669"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("87fa6628-7eb4-419d-bc7f-234289425766"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("88144215-e8d1-4d53-9f19-23451aac8bfa"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("887287d6-2e99-4308-8823-4911c9ef2c68"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("888f30ba-d2e2-469e-991c-709024ad22dc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8a476269-1d65-4081-b5dd-bd2b90915456"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8a6a4f0a-3ae7-4532-94c6-df70297fd266"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8c647376-d1e8-4f84-90d4-ea2aa19fc756"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8d55243b-0ea9-4ee8-95dd-7ebaaef3be00"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8ea751ef-78ee-4c45-81ce-0626977f8eed"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8ea8fa76-3127-44e3-836e-ed3a3ea410cf"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("906eba35-883c-4e35-bddd-49f5aeb4cd9e"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("92591341-fac1-4533-9226-9bab834beec8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("964f409a-bc52-4e1c-98ed-115a4a050d12"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("96cd1885-b61a-46ee-a911-5df120f68653"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9877cecb-9514-4e04-9268-1e3514b33281"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("9ee128f8-d94a-4679-896f-056660d320bf"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a0cd8a21-679d-4562-96c3-c52040971a1c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a19f335c-c84a-44a7-8934-fe9e828ed051"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a30b3646-86d6-42a8-b362-6d0d39d87e5c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("abd37237-b82e-4ab4-9456-cd48201894ab"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ac2790d7-d8d7-4dc6-ade0-e81fac94b584"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("acdfe568-4738-49ea-9732-aa4b6d962a56"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ae2c9198-8f80-4316-8c01-375e3c6cef16"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ae3ef366-ae87-4cbd-83f2-f7ea62565fa2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b0a4c3c0-031e-4537-b799-e48864e04871"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b3fea6cb-ec27-4654-b22e-81a6f1eb4e4b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b43c8360-6818-4898-8782-d5214b9202b9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b5ecf4e0-475d-49a4-8ebd-fcbaca72b064"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b78f6aea-b2c2-4505-bb5e-407346710e88"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ba3424d8-d1d7-413e-804e-beb765e6e40d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ba619330-11cc-4550-86e1-ae1145edc7be"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bb1b93fa-9892-41f1-8c88-2e23b5a6d43f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bb294a85-320e-4639-a60b-00ba3cc3e0dd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bd671072-45de-4f50-adb9-49c7830077f6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("bdf7b7fd-f55b-4c49-b36b-19c16723469e"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("be4096aa-e018-427a-8b73-64e4125819fc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("bf23c0cd-ce04-4e13-b2d5-3ab072d09a78"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bfdfb72b-c0ab-4905-95c7-6512447b2859"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c11d2ca5-42c7-4cb1-bb9e-e7f9525be5b2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c3c4beba-a3bf-415c-abeb-3748af547dab"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c66e6aa5-4c50-43ec-8fc8-194960e73a01"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c80bb5d5-78b5-45e5-ad66-6c025229a192"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c921072f-1ba1-4472-b574-bb0255f3519b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("caa54e94-33e6-4578-93de-e297267ee16b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("cd03223a-073a-4d73-b8bd-9d8cd87cf7ec"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cde5dc59-20e9-4722-a089-f456b5af3416"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("cf830f43-a98d-4bfc-8c91-4e67a5b6faa2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d0cddc84-dc63-4aee-8132-90c678fc8bb3"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("d2304664-2829-4d37-8423-e3673665e0cf"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("d5a50e38-0277-4abf-94b6-985c8297003e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d7d5f8b1-668f-4689-8365-06012d9e6270"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("db69f4b7-a387-4d40-8d4b-96c854238dde"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dc17574b-88d1-4902-9077-e1d0d5406aa8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dd2c39d1-8242-4e9e-8400-26ca9e781368"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ddf87bac-150e-4c88-9b8e-c2c81758b141"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("df607b06-b42e-42fc-9e4f-1cb129e624c7"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e10fb377-2b80-4dec-a598-8b23491b665e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e2c5243d-7391-47c3-b359-38122552d102"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e2fb3a72-1e1b-404f-8b8e-f144b110fadb"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e5362b2f-3101-4832-af1f-82c15ecc980f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e62d1b7b-a71c-424d-8ae9-e91dc3277155"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("ea763356-0aaa-4aa1-afdd-c924bf968580"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ecf43ff0-2429-40b6-8085-052185b59aca"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ed7ed29d-86ba-41b4-a68b-245f0861cd9a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ed8a4318-f621-409a-a0b4-fb91d5b8a36e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f5faefa9-210e-4a37-8dc7-ac33f42b4031"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f889cc7f-d89c-4062-9fad-54f8b5690827"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f92e21f0-291e-4452-beac-bc4a51c1a397"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fa0e14d4-7429-40f7-8f18-362ad9036736"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("fad69c2f-04d2-4230-a7af-907c9c34a88f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookTitleItems_BookTitleId",
                table: "BookTitleItems",
                column: "BookTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookTitleItems_LoanBookId",
                table: "Loans",
                column: "LoanBookId",
                principalTable: "BookTitleItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookTitleItems_LoanBookId",
                table: "Loans");

            migrationBuilder.DropTable(
                name: "BookTitleItems");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookTitles",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BookTitles",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookTitleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsBorrowed = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookItems_BookTitles_BookTitleId",
                        column: x => x.BookTitleId,
                        principalTable: "BookTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BookItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("009e9651-ffc6-424e-af83-6a17d1d81426"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("02266906-948e-4001-8471-a36af4c315bd"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("04855c69-7899-45df-b0d4-c8ab0e2b1125"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("08267a3c-7f71-45e6-987e-3fa54288c0ba"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("090a57e7-57fb-41d6-80dd-58575e01e504"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("091d4a14-1fd1-4469-a5bc-6da167c29c4b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("0b16ab75-63a0-4266-8c98-36dfdcc77af3"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0f36bac8-071b-4f79-911b-a311dc72e7c5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("104bb48a-4e62-4e26-9ea3-92893f857fd1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1190b225-90a2-47bd-b2e6-7535ef1d9fb0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("16a71524-6028-4246-a858-89463e73e684"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("173924e0-167f-4fe4-a989-26c15dcce20e"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("17ecfa9c-6e18-4a34-a358-0bdc0903c9cb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1accaee0-4294-4847-86d0-c7584033f927"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("1b6b123d-426b-4f73-9080-98410f3b6269"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1e30640f-d60c-4ed2-8e77-4884b685b84f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1eaea26d-13b9-4b09-89fd-70a97e67423d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("20fcc1ed-fb13-44d4-9be7-7e1d64d95e93"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("217a0857-ea2c-45d0-afcb-1b847de24173"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("28063487-b860-4329-86e2-21db1c813e79"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("28a3085b-fa18-4d14-beee-3b91624051a2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2baf47aa-2100-47d0-8104-cd8fbbc73d7e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2d4c2693-4daa-42a8-a64b-83adfe7b7f27"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2eda274e-1d35-44e7-a861-7f5e08fd6b58"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3007b622-6b90-4be4-83b7-949b5d68fd6c"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("300c6882-021e-411c-b700-fe149fe387b1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("304b7361-efa0-4199-8f0c-0cfad8e91640"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("310e1cf1-2d08-4078-9cdb-d6023f0d33da"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("35d21485-222c-4c8a-b8c3-223a5f443791"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("362494f3-fc1d-4248-badb-b6a663801145"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("36ad5ef3-458a-4b8c-a8c3-5f9d6dad3145"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("36baf297-f769-4f0b-a996-dbfeb205fd35"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("378e62f7-06f7-4d71-8892-c7469d8af1af"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3a04266a-ef79-4b64-87ae-65db81db2890"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("3af06865-c895-4fc5-821e-fc8b3bda96e9"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("3bbb87b4-6c66-49a1-9e3b-87ed9aada1f6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3be8a52e-2855-48e8-954f-ebb3cb2fecf7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3caf031d-9b20-435e-a8ba-dc2db46af0c9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3f15e1df-7890-4328-9b07-2ef5c030430c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("403faddc-71c5-4804-94e1-d01cb3201db0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("41e53ba1-9f71-4dc3-b9f2-4cc5cc06a8e5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("425ef931-e93c-42b2-adbb-85e3639d3d2a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("4275a3b4-ff3d-42ae-a6db-3fd028b07013"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("42a078cf-569f-48cd-93dd-4bf8a016cf62"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("45ed94e6-3cce-459a-8392-58294b9bf749"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4781af55-49d9-447d-b59e-e949d209a5ce"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("49e74183-6720-4f7b-a2e7-b674efdb6482"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("4ab17a0e-6f75-4a7d-9115-e99ebb1d1206"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4ad94162-89d1-434b-bdd3-e67438a68f39"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("4b13b468-e28a-4ea7-a4c7-5d23343e10c1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("524a42de-a806-44ba-b8f2-d6070fa8e700"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("52a359de-fcad-4097-8bf8-33af8b9fc2b2"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("52c39dc2-5b05-4443-8818-31a02a62a7f7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("539acbbb-a1f2-404b-aa9c-676e6fa9d162"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("55b4e75e-f2b7-4584-8bb0-e815a221c3e6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("570013b1-ec80-4066-afdc-6c0d65a46379"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("5923c2db-d6b7-471d-bb92-18f00928d77b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("59261154-14f6-45b9-b681-5bb58da63b49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5b75c3b8-e964-4c38-9088-69f119e53873"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5d1ef4ce-6606-4f8e-a8ed-0cf723f65669"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5edcd8cc-249f-4141-9599-48bf32513bc4"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5f4d310d-b8f3-4647-93bc-a12a46fcb90e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5fb6f12f-7e72-4dae-8705-5b57de340810"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("61022a3d-aac5-437a-87f5-b0ea6fb25f06"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("65c06fc6-c9a7-47cc-9cb4-9b52314949a5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("665fe74f-85a4-4a84-9741-815021b35fba"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("66b3974e-5d67-4af3-98e3-9c6f9596915f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("67699d38-12a4-4f6a-8fb7-fe1e897736a0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("67ac8d2f-ee16-449a-a487-4139371d1e9e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("69f0d00d-53b2-4245-8ee7-a5d0189a8a67"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6ac3a1c0-ad5d-42fb-b013-6b7a04b9c6b8"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("714e8a40-88eb-4dd6-afbc-e0777871e3b1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("72e9737a-30ff-4be9-a3b3-52c95b70b539"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7478d254-29d7-498a-a108-24b76cd7595e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("78f0a0d2-e5b7-48ba-8963-7a8a0eedc9ae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("79a15ed7-ccd3-411a-b806-18aa661c6e2a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7b3d7085-ed80-4c89-bf2b-2132306a145d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("7d669002-426c-4eb4-a3e6-e2ad09869dc9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("80f6f712-9172-40ac-9517-5ef7c2612117"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8164253c-18cd-4f5c-8e60-804c04a37492"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("83079909-9f0c-4beb-ac12-d8e888d579c1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8690f02b-b811-4b6c-beb6-03aa16217f38"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("871284db-4f4b-47fb-a8a7-b9112df7a0c3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8ab1bc35-c615-4dc8-9a7b-40512e32d159"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("8d066e8d-af52-4530-813a-d286641b72e8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("8d125c2e-cd16-4fdf-b555-b1062a3e611f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8e8f5ee7-6ac8-47fe-8005-dbad159ad2d3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9009b639-8f16-4d6d-97d6-50106f5b96df"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("91bae52e-e10b-4c09-bff4-acb85d9746d3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9284a374-a01b-4643-a557-6bd453bfbb00"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("965b0c21-a5c5-4915-aa0e-4df744457c73"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9756223c-f608-4360-9462-74b3d5883ad1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9870024f-bbf7-4c41-9c9f-0ba4def7f0ae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9a0cece0-1d8e-4c8f-bd5d-0986b9ff409c"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("9b219fa0-4a10-4f3b-a04e-b4a67c53a74b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("9c006e4c-4cdb-4a5c-bce6-575d9d0b36b5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9c5db6a6-464d-445b-8de8-602dcd4591c4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9e703b67-af42-49cc-acca-c8a362b6ca8a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9f36e916-7f5c-48c5-bea4-bdb5da33fc89"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a1794f97-ee6f-4a1f-bd63-ec1c3429b01e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a22c6046-d1e9-4bdf-9abc-59dc4a427ebf"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("aba0097c-4ecc-4577-b691-3eade77a4c4f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("aca61446-70c8-4d6d-b13e-282cd4788c31"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("acdc7aa1-3315-4d9c-bf1e-c59af549b6d1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("af002f95-aa1f-410d-a222-935158f633f3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("afb24a56-0b20-4980-a78c-7ad29a4ebcb9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b10fee82-cd9a-4b12-a6ae-acfbd4c2f9b2"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b155a2e4-b41a-4d49-b505-4d7a54764298"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b5133cac-9750-476c-bd34-3e799de51095"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b543a69e-67a4-4138-abad-63ec5ad321eb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b8e5b3f7-4ef5-47a8-8bfc-c0f741cae33c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bacba8d8-7578-4d00-be01-6ea0e90525e8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbd92047-eb5d-4384-9c8c-a016725c5c46"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbfd47dc-80a9-4355-8781-5540fcefdfd5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bdc60185-a297-4625-91a6-2c35d628ff80"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c077c3ea-8c81-4fd6-99c0-d42330b7ea4d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c1ec680c-6ceb-40c3-9c38-bfea9cac189a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c37165d1-3aa3-4ffa-bf18-9d46b3cc2f2b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c452d927-dce8-4feb-8a5f-1657edc37ede"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c4bb61a9-158b-4ef4-8ac0-303112d6cd30"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c92412be-8994-417a-a536-926ff637e456"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c937bfd7-ed18-4c81-9d17-f0c3723fd693"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c9a788c0-9de6-46c1-891c-5f512c5b287b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c9f08002-792d-4a90-8017-997af6b88a44"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cc473831-d78b-417a-848e-9a061901687d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("cc797d5c-550c-4253-8baa-1cc792aa73f2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cca018e9-f27a-4767-91f5-0dabeb5d94e4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d09f669c-8e0f-4a6d-8c3d-6eea78d3fbb5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("d1da2ed5-7854-4335-bd3c-f2487af50e49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d2f8c6f1-c616-4ae7-857b-9f6fbc50b6fb"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d46d51b1-874a-47b1-a634-0e689e3c8403"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d4c85a3b-9eb3-4873-8100-178d0f96925e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d56bf415-81d0-4a71-b30d-818c3d901856"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d5e458c0-571e-41ee-ac81-3b44355c9002"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d601b3f6-a1ff-42b3-9da4-5123f286fdf9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d6d7baaa-9dd1-4569-8fa9-9d185e343551"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d8c4610b-9cc2-477a-8af6-04226bdcdb82"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("daabc93c-f169-4df5-805c-df239ec249f0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dda1b0b2-a062-4746-98ab-134910866b89"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("df6ef278-87ad-4592-be78-81dacd2be3d7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e02586b7-f981-4224-9a7d-61ab23f50abc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e10e255c-7949-4686-a0ad-542194ec408d"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e3f89ffa-0a18-49a4-b26e-b5accaa17b67"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e5673332-79c3-4df3-963c-e6f120144bb2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e64cfc17-fb0e-481b-9f5a-1703ed8d5b4a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e6579027-cf01-4bbc-b709-77d90f184ca7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e65e07ea-19f7-46cb-b750-8f601ac51cfd"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e69126c1-417e-495e-b098-c6f8b9f90c3d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e7392887-0dd9-441a-98c2-a8f698f110b3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ea7ff54d-a6b8-419c-9681-59a606576bb8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("eaa2dbf8-f553-4fc5-a132-14c06bc94c8a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ebcaea0d-4dbc-4235-a831-fc57f7dbdece"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ee2d8b35-028e-4ba8-9ddb-5a9fb677b9cd"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f14589c7-bdf8-4540-b969-17eb4ab5dc7d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f173962c-42fd-417c-8070-423f10a64b45"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f4b3c88b-6d41-4ab0-b78d-5fe0f04fca4f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("fb9f2a57-ca2a-43af-a63b-fb12cbdc9425"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fd28f38b-a506-4b62-bca9-a103a4211e74"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("fda6732c-c64a-4c4f-9c4b-1a89cc91b907"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookItems_BookTitleId",
                table: "BookItems",
                column: "BookTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookItems_LoanBookId",
                table: "Loans",
                column: "LoanBookId",
                principalTable: "BookItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
