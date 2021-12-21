using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaxBooks = table.Column<int>(type: "int", nullable: false),
                    MaxDays = table.Column<int>(type: "int", nullable: false),
                    Fine = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookTitleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BorrowerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoanTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookTitles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalNumber = table.Column<int>(type: "int", nullable: false),
                    Revations = table.Column<int>(type: "int", nullable: false),
                    BorrowedNumber = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookTitles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BorrowerId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoanBookId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoanDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_AspNetUsers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_BookTitleItems_LoanBookId",
                        column: x => x.LoanBookId,
                        principalTable: "BookTitleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "268e8b29-6cf7-40cc-a1f5-071621778a74", "011dcdc6-798c-48dc-ae09-602567435cc9", "SuperAdmin", "SUPERADMIN" },
                    { "2cd88126-a879-4287-89bc-111d74d6e7d8", "05405eb3-5e05-425c-a679-ef6a01c87426", "Borrower", "BORROWER" },
                    { "415dc1d8-cdb8-4a71-ad9b-97409f8e972e", "c8e18e6d-0f45-491e-b91e-607bdb89249e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fine", "LockoutEnabled", "LockoutEnd", "MaxBooks", "MaxDays", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6b99524d-2abc-4f01-9e8f-1b3ff48de805", 0, "95586a2a-6140-48a1-ad6c-095cc53035e4", "horaoen@gmail.com", false, 0, false, null, 0, 0, "HORAOEN@GMAIL.COM", "HORAOEN", "AQAAAAEAACcQAAAAEPJ1VLxNjgMGj9JxLjxI6HSkhKCfLz+9e/HOxBrBvZ79P/nUM5LtOxX1X70RRFmA5Q==", "15137667148", false, "3ad4f715-1180-4435-9557-3c0ecff31c2d", false, "horaoen" },
                    { "be165330-0e1b-4f2c-b6bb-28205984b402", 0, "9793e7c5-a3b2-4978-9442-68720c0ef511", "bleso624@gmail.com", false, 0, false, null, 0, 0, "BLESO624@GMAIL.COM", "BLESO", "AQAAAAEAACcQAAAAEGgZVAw4glP0V//v33H9+UERgKGtjALFnr7gpT2HqTKHCeGdU2JRSKYe/d3FShW1NA==", "15137667148", false, "76b109e2-d719-4c8d-a9be-0511281ff720", false, "bleso" },
                    { "eee53bf9-92f6-4c67-9bdf-5ed27674e79b", 0, "24fb6b0b-67fe-4ea6-8c38-01b5b20d5906", "2495644988@qq.com", false, 0, false, null, 0, 0, "2495644988@qq.com", "FHR", "AQAAAAEAACcQAAAAEMWz0SPwAHtEjReruMXVGhe8ewJYZwN2sEnCdc3IYJmcHiLf5/aoUEjhZB1/7G+Oww==", "15137667148", false, "9018173b-f27c-4527-b088-91be37f1cdd2", false, "fhr" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "268e8b29-6cf7-40cc-a1f5-071621778a74", "6b99524d-2abc-4f01-9e8f-1b3ff48de805" },
                    { "415dc1d8-cdb8-4a71-ad9b-97409f8e972e", "be165330-0e1b-4f2c-b6bb-28205984b402" },
                    { "2cd88126-a879-4287-89bc-111d74d6e7d8", "eee53bf9-92f6-4c67-9bdf-5ed27674e79b" }
                });

            migrationBuilder.InsertData(
                table: "BookTitleItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("0023585b-e9f9-45af-a968-9060169cfa23"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("018bec4f-bb1d-4ed1-bef8-add48478b8f6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("01cdb900-597a-4c18-b5ab-e13e491a3c8e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0277778d-bddd-4807-9cfb-1a0805997745"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("06d00912-4234-446d-857e-c32d05902d60"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("07bcf1b5-007d-4fa0-b73d-917e375a18cc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("08ee70e9-4506-4eea-8910-6d6b6c89fcd7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("09ab015b-d710-4066-80bb-0fa9b5989466"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0a4ed94d-7cb3-43eb-a791-7497404acac4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0a94c35c-648d-4c5d-9dee-34b31ffa164e"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0ac0d64f-b54a-407d-90ee-11bc1c5e12b5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0b9b7837-48de-48ad-bc07-aa0b2debb33a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1004b93c-9b0f-4123-9c4f-46cf4dbb19cd"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("127a18fb-c4a6-49c0-8725-e7d58a7beb10"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1443b145-3444-443f-a8af-f9abd02273ae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("161ca6e5-dee8-4311-b205-89ffdd33729a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("17545f97-d079-46cc-a1d2-fe907890cfb9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("185988f0-4f20-47cb-bbb3-cb88de840ffa"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1a235851-38c3-4613-88a4-ca77bfc3869b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1dc0d81e-fd5d-4e9c-bc65-957f522902e9"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1f91c2dc-9698-405d-aeba-1aba19ba6dda"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1fb51ee8-2c1b-4477-852b-bbea15312d96"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("200f747f-6b0e-4caa-8ef9-c86326d3bcac"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("212cb194-e1c7-4fbc-8514-8fa7b1803f3b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("223ab263-169f-4a9f-bdb5-be573b31f82f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("22a2be20-de50-465d-b032-bb21a7df2ea6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("22aac5b3-8917-415d-9b00-3e48a488d41e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2577ea44-f0f1-4052-bf8f-a2ea93241134"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("261fcb38-761f-4df6-b661-44c322b0bc10"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("26f44843-b3fd-41b1-99b8-5588a84b96b1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("27b4b594-0ba8-4ea1-bef8-36fc466dd56a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("287d4dcf-5a57-4089-bc78-af809c079db3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2c1e582f-9b06-47e9-8d32-def406d2b64b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2d77618b-67d4-47ce-b1a3-66595e6cd5db"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2e53647b-1d99-40aa-86d9-6849e90a5985"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2fb132f2-8f66-4c7b-8bb3-48612dcdd2c0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("314b4c42-ef6f-4062-b0f3-158120b45cd4"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("33dab172-0410-4545-8342-eb1bec70cc4f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3962a484-db64-43aa-a60d-8c4c312d8353"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3a009424-0388-4810-bebb-1e70c238f02f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3e216474-8510-4792-a4c5-476d54e2ea68"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3e5d92b8-6d1c-4131-a6c8-053cfa3418e7"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3f70e89e-bb4d-4e19-8673-cb36205a9629"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("41151a63-7b78-4845-bdad-2d5f89d5b8ee"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("417c4193-4b6f-4593-88ef-dd4e83345006"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("435f8402-eddd-406b-8f0f-2b82b2758f0e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("471321c7-ec04-42c5-b127-2b7566270897"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4949ad9b-1038-4143-9003-723320a207d4"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("49d4fda0-2790-4dcd-a08d-621c3253ba2b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4b7bd2dd-7429-4864-b916-7f76cdbedcdf"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4f404fae-d142-458c-afb0-c4ace2965cd5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("50b22789-5584-4afd-a846-d259ed549937"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("50ed2ce2-5f53-4319-afe6-c9a5906901d6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("57642f66-230c-4605-99f2-5cfb6bcf85ab"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("584328b9-1c79-4669-ae9e-9150fde09556"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("59863d16-87ad-441c-8883-4eda76808421"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5c9c9470-f868-4a92-aa0b-49a45731b35d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5ddaf7c6-a221-48f6-ad9a-5eace24cf2b9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5e90bd5d-677c-4b1b-bc9b-00805b1faebe"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("5ef5262a-6a81-4a7b-9e22-05e7a3842851"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5fe2f8d8-0a73-40a4-a252-9ac59a865655"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("608f8736-1161-4829-8731-5eed0cc92562"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("63ff37da-de23-4432-a588-8f1f620e2d65"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("66feac2f-80e9-4a63-a822-7e8caa3058dc"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("6a17d8c7-e762-4c6b-91fd-9bcb0d2d5f92"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6b2a5078-2948-47ab-8ad7-8d17b4469036"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("6b48e5c0-93c2-42aa-85ef-769e70fb74b0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6b4b0df5-0411-4a8f-86b3-ab3e94ed97aa"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("6be9e332-469d-4c5a-9ba7-c21992a21a92"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("6ca3a3e3-760f-4c35-aba1-c3a74d321476"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("6deb4e88-a0e2-4651-adf6-79ea0d26a7be"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("6f019ff6-cb31-4fcf-8309-a01831106d80"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7406bf15-87fe-4aef-a104-b4e10a8188b8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("75395675-d3f8-4f63-a59f-4e8c83d2eb73"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("794a4e19-9e96-4efb-9832-529c3d8058d5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7f19ffe3-72f3-4a61-9bd5-a105f7e55655"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("80cdf816-3ac9-4efa-b4e7-a7489b738cbe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("812fc6e3-2f23-4eba-a4fc-7ae9f80b0e0c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("813da75c-4be5-45d6-8628-0ae6fce97edb"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("82aadafd-4a3c-4348-83b5-271d45bc10cc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("82ab4f54-459f-4d9b-9966-d686026382f1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("82fa0b32-22ac-4942-bce2-70624c5dd526"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("833b997a-c16d-4691-8e5b-d7d2173fd640"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("85e111ee-7a62-4932-97f3-e7135c987857"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8799ee7d-0466-42ee-9957-ca42cd9cff0c"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("88247d47-2de0-4959-8117-a6f9995054ca"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8944fdb8-9c75-4b81-9b85-5689a9c561b3"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8c00030d-85c2-416b-98b0-a4d423d75819"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("8e7197f1-2f84-4a44-9c4d-c069c5a19840"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9005126a-d353-4c76-ad44-4982d88bb33a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("91fc40a2-b3b9-4f86-af0e-b92ed2c772d9"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("97dc91a5-8775-487b-a1d2-2014b855f9e8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("99829259-ec17-483e-bb58-d609e2af0b2c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9b4fd677-2770-49c3-a611-723ddc5d3528"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9c88979d-c02f-45df-ba42-c2c41d7cbce0"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("9d4060be-f9b9-4802-b20b-5f20f44dcca2"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a134d3ef-b861-4287-a698-d7160150bd9b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("a2699a22-be07-4b04-9c3c-8afae450d8ca"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a310eee4-a5f2-4ad7-b0bf-cd23e823c959"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("a49c85c4-f6ae-4384-82c4-4abedfe175c1"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a619508c-01c5-490d-a1bd-466054df38c4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a6b10c98-b38c-4683-90ee-585e76c4ca08"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a6ef8820-f492-43f9-aa4f-cf7f27f4d10a"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a708ec59-7161-4ecf-822b-9bc848bb7840"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a7167f80-387e-48ff-b397-06b5dc86f5dd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a8741e83-9e94-4ff1-afed-917390988b8a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ad42935e-4305-42e5-8df9-240394f7c679"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ad5ee9ea-1b30-4aaf-9c97-a683bccf1578"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("af55f8c2-069f-4839-a3ce-5ee3015d1cc9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b109c1fa-9251-4230-ab9d-cc4a1345ab52"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b41a60ac-fa35-4da8-918d-cd27ce721581"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b590c305-3f9f-4e41-aac5-a43004fde2d4"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b61adc2f-ec2a-4423-b10e-8e2956d82357"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("b726901d-f4f9-4a45-aeb5-a562b4cda981"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b8cbc928-9e13-4b6e-9acc-f73f05d72172"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bb25048e-8407-47e1-ba77-e9f6926224b3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bd847cff-6c25-4d27-95b4-b93f6a129f89"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c6041084-1d87-45f1-b286-cce087ce3338"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c6d03011-6484-40ca-afe5-74f91d40d157"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c85efa21-1774-4196-bfe9-89f55ffdac50"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c9625cdc-268a-401e-838d-393690fb6c52"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c9d22ef8-bf2c-431f-b1a7-ae057f3e713c"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("ca0e98d5-c130-4aad-b770-53b3066a87fd"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("caa72a11-0bde-421b-ba31-1a5239bdfdfa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cc961c9c-78e6-490f-b1a7-ecb81ff35060"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cd188858-b183-4d7b-809a-8b98f1d2adb6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cdb99db7-776b-44ff-9499-795486d2f5f8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d0800069-c608-4ee8-bf14-7cb6e6d836b7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d1194210-5df4-415d-996c-09a67e8d7a36"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("d2d4a687-1580-4b59-b9ac-25e8881d8b41"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d69ecc3d-03f7-4f26-8276-7906bd78a526"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d6f3d4ec-3831-4146-bb77-cd2fa3025666"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d84377f4-0627-4737-9996-d40176ca1db6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d8a732d5-7f0e-4a4e-b3d7-d8a7343c91ab"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("da136616-6712-450d-88e5-b8279b934e16"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dc089332-0569-49c7-8564-daccd142f1aa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dc246967-f387-446b-a3a8-2746d1b810bd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dc763d2b-4be4-4b71-8d18-0952184e9217"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dd25ad1a-e29c-48d7-beaa-36ae8c00ca5f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dee54538-5584-44c8-91fb-0d592f082748"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dff21ab5-ad6f-4198-882b-dcb27c817867"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e0a04d13-e4d0-49ae-98cb-3e2745d3d88f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e2176851-4c08-458d-9895-331e69d89e98"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e2423767-2cf9-4494-8184-3c329aa3033a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e3713f65-5bc0-4b2b-8866-23e3e12660fa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e4142261-f9ed-457c-b79e-2da7900024a9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e43d8470-cd4b-4a86-8097-8fb3f9d452c1"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ec4b840c-6bf4-4a4a-9791-fbc5fc8f3b11"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ec88a65f-bb26-4fe2-863b-1f13374f8d2f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("ee475e5c-feb9-4cce-8567-18d516b8156c"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("eecad7bf-35e7-41d8-b40b-5ad6ff914fff"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f362cb8e-1905-4692-9fa3-f5a542a500fc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f4d6b8d6-5a89-4c31-96e1-a5a663cdb676"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f56e75ff-a25f-4bff-b329-8b3643cb209f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f652cbab-88fa-4ecd-9fe5-60a5428da54b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f6866cc5-7309-4647-b8fa-ecf060709468"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f6de8684-f43e-42a6-993d-8ccfb5ebbc2d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f7dd2a9b-1727-4a94-8cd1-50dcebecba19"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("fae8f95b-8c5e-4a2a-ad89-fa2edac0369c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookTitleItems_BookTitleId",
                table: "BookTitleItems",
                column: "BookTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTitles_UserId",
                table: "BookTitles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BorrowerId",
                table: "Loans",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanBookId",
                table: "Loans",
                column: "LoanBookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BookTitleItems");

            migrationBuilder.DropTable(
                name: "BookTitles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
