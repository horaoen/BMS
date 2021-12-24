using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class test : Migration
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
                    { "7b8678e4-cd59-4695-af77-73f88fca1519", "c8c00f27-0c1b-4ef6-95db-ef45c8a8907d", "Admin", "ADMIN" },
                    { "ba32d78e-3c58-4846-8b35-d0556dd64d28", "6c389c27-ad07-4cdc-98b0-cedff441c3a3", "Borrower", "BORROWER" },
                    { "c3fe4c45-350e-4a5a-9dd3-c4d2e6c90de2", "65f84432-e20e-43e7-a0be-412143479d7e", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fine", "LockoutEnabled", "LockoutEnd", "MaxBooks", "MaxDays", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "49378fd1-a596-43b7-8f79-fb7863af4aa5", 0, "415ab97c-0c3a-4b8d-96e1-ae8c0db8704c", "bleso624@gmail.com", false, 0, false, null, 0, 0, "BLESO624@GMAIL.COM", "BLESO", "AQAAAAEAACcQAAAAEFNyhzyEuYOgFdMQES+kFp8/w/X3XDL8j+vAU7o001bdEa6KadYuaB9yhDUG4AAm/Q==", "15137667148", false, "399f0fe8-1f95-43c9-a490-1ef5664c7902", false, "bleso" },
                    { "8fb1e8e9-a583-4fee-b293-26be7cd768ea", 0, "e2326cab-6e9f-49c8-8638-a41d23e58dfb", "2495644988@qq.com", false, 0, false, null, 0, 0, "2495644988@qq.com", "FHR", "AQAAAAEAACcQAAAAEExwngVivJYslQ5TfpyV1jE3XeZa/aWAjI0qZOuGT/C3rsIxlmvSHCNpyRuYH4vPiQ==", "15137667148", false, "7b0a58dc-b744-4a1e-b5ca-4b2ec90be33a", false, "fhr" },
                    { "f4a6a6c4-ce3d-4643-9f52-3265ad4f811e", 0, "249d6bd5-cb3f-428d-aa3f-5ffec3529973", "horaoen@gmail.com", false, 0, false, null, 0, 0, "HORAOEN@GMAIL.COM", "HORAOEN", "AQAAAAEAACcQAAAAEH2WP9+FVNS8wSrLExjvlskuLtglScANOR4rb0JgEhZMm2PvPuBx57ZTMligk7nk6w==", "15137667148", false, "f17e0ed3-3c1e-4978-9f9e-e02dc54a02fe", false, "horaoen" }
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
                    { "7b8678e4-cd59-4695-af77-73f88fca1519", "49378fd1-a596-43b7-8f79-fb7863af4aa5" },
                    { "ba32d78e-3c58-4846-8b35-d0556dd64d28", "8fb1e8e9-a583-4fee-b293-26be7cd768ea" },
                    { "c3fe4c45-350e-4a5a-9dd3-c4d2e6c90de2", "f4a6a6c4-ce3d-4643-9f52-3265ad4f811e" }
                });

            migrationBuilder.InsertData(
                table: "BookTitleItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("00c84260-0e07-4057-9a44-d2ee27cf0a22"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0201687c-4878-41a4-919f-631b910a375a"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("032b2d5a-c971-4777-acba-ea3c4835b56a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("033d3d13-ccbf-44e2-b999-4840936fe2b1"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("040b6901-3336-4964-9f75-e1f1983e8da9"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("041526be-69b7-4bc3-b7ca-6e232d18204c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("06d606c8-82f6-4db2-b190-8bc166b1aebf"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("073dc290-95cb-4101-92c7-771f4ef83c41"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("08d4775a-cfc1-4237-8817-66f8101f4bea"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0989236a-4fe0-4c64-a1a9-cff883973425"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("09ba1285-7e2d-4bab-8c15-944fed52c2ee"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0a7d1ce7-5a55-48f9-9730-966ba01a9043"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("0a80dae7-6ed6-47a7-9998-6ff34a584b6d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0b76e0d7-55d5-45d5-86db-b262054ca74a"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0c1e72aa-8bcf-4e5b-b513-d949eddb8b6e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0c6b7b09-6e77-41bd-a153-3b3d32fec5e8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0e1d4996-026f-44c9-a371-e9bf4f86eb3b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0fe6f3a6-8358-4ffb-8187-89ae8c57c707"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("15c8bfa2-1e12-4137-9157-635724709e73"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("16345974-21f7-464a-9fb1-73c0fa51546c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("169faf81-3410-4ce6-ad75-e861f36cd4fd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("19b11ff4-ccd4-4f9d-b0c0-57c93bb17373"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1ad77b40-8afe-4516-9b3c-983eeb109871"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1d26103b-dd4d-47aa-bf65-1ce6bd310587"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1dab634f-28fc-40ef-ae70-22c21e5a3a5a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1efb252b-d307-46af-ac87-e43811bb3a13"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1f29426d-93f6-42e2-8f61-858549d2b47b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1f3991a3-b4be-4461-b4f5-4a0cdbbd15f5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1f99e0fa-49d2-42bd-a9e3-268dc0701d13"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("20605890-3aec-4f19-9a2e-3c70dc3de692"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("21398c94-c748-43da-bfd3-20393adc82c6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("232990e0-9036-46d0-a2b9-7d1b080d8017"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("29e489ae-436b-4556-aad0-f1f71f36aa01"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("2b0e06e7-725e-4c25-a60f-677cebf26bf5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2b7d0c2c-0778-4d95-8d44-a0a89608fb78"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2b89d42a-0c23-4a1f-b824-5341142911cc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2c408436-e4d6-4fcf-a186-801813d3a693"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2ddb20d3-3f0b-4eb7-a0fd-b09edf178015"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2f934cca-046f-44ad-9161-99e2ac381551"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("300db50f-8ee6-4174-a24b-2e11d4956c83"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("30bf5c70-a5cd-43b2-a110-bc56abc75688"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("32c26420-87df-49e3-a708-24ff656f1e85"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("34c9e7c3-b692-47de-98db-92eb3bacf42f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("38d0d966-737d-4c0a-8ee6-ffe0afb1dd0f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3d8cafec-fc7a-4d44-9a0e-cb84e663c752"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("41855052-ffbf-412c-bdbc-ce3ea6f92855"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("41c32622-fdc6-4f84-801c-a48d9278d90c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("42ac3d29-31c3-4825-8ee2-397c55b6c07c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("43d40f35-6463-4f0a-8fec-748eac959fb4"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("46f3962b-e847-4ab5-be74-043187126f64"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4735e817-4c87-405d-8b8c-d1588dae2504"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("498dbab7-112a-41c5-8292-d662a7158fca"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4b36ed66-a453-4600-a87e-e321da607403"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4cc810f4-e83f-4d62-aade-5be3092015a8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4d949c58-c733-4d17-831f-3127941d1767"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4eacb830-9d08-477e-97bb-9ffe4d89fd0e"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("4fc8bc70-1ba0-4538-8e09-4a1b3b5dbfe0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("51311ea6-e34d-431b-b55b-d4a2f285ff12"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5491010b-c6fb-4c6f-9f85-9d62113f5cdd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("549b9f6d-9c00-43ad-a1ea-3a2aa7ddfda1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("5829932e-ce1c-4847-92fd-45c55f62faa5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("58416ac1-c113-445a-a394-e13987c62cb9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("5dcfe0b8-e850-48cc-bdd1-c25d48dbbc59"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5dfb51b7-b0be-4993-b214-c348d62aba99"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5e34d5c0-cb12-4168-aa78-ef0f49cfaaf6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5f226428-ba92-4750-af07-9a4060f49a81"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("60e7a4a6-8933-421e-98c4-5ea82aa52543"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("636ff2ee-ca93-464a-aa85-b40253dec4e7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6417d22e-c19e-493e-9f02-6ec7062f3074"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("64632a11-cf90-4c97-9517-e4d47756f05a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("66372442-c95c-489b-acd8-beba5718e602"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("69aa89da-0c86-4918-ac5d-01d4abfb4d4f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6aa1bc43-df17-4be0-9b60-805cec10ee3f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("6c822ec3-f75f-4030-9c83-5e2464f00ef1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6d9419b0-339e-4f86-90fc-417f528220af"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("71ef21a8-7285-40a6-a1fa-beabd23b5069"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("721e54b1-9e19-43ab-82cc-2349c1c829a6"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("74254481-04ef-4472-9516-5e635b42282b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("74ddcb9f-d162-401d-a8fb-1a76c5591009"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("763f46ba-0b6f-4252-92a8-0aa9152b9544"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("793dda79-be65-49df-839f-e8bfb0e46e3e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7db158e0-0afe-4d82-96a0-ac8b77fb38c9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7ec4903a-8817-40a8-9e20-b7f86fb0ffb2"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("80724f9c-b8a8-4c08-ac34-ce9417d6ec72"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8196846c-d92b-4895-8a55-e96bca07f98d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("81e7b671-ab4d-4103-93d5-83e895c8d419"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("84d0565f-7761-4425-8b3b-596482cb6b79"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("85997271-936c-4033-a137-cfb9464a2c45"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("85fa0341-021a-4943-9c97-6e87ab7bd1aa"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("876305ac-2361-46ee-9d09-a591cd876eb0"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("883d8d5e-766e-40b8-abc5-4b8d8a0f8676"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8a17402e-845b-4269-b6e2-881efb669400"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8bee60c6-beaa-487d-abde-817d301e9bcc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8d6725ba-f855-40b6-88a8-cd32428bc69a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9603f827-f001-4c84-9e3a-29c1a555bb63"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("98ed4332-a2c6-4d5a-9701-52bd6f272359"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9a7437cb-5b05-40e1-8716-36745137860b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("9d8c4e0a-8060-4a34-ae98-2c7b8a28e9a8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a0062ee8-c503-461d-8839-90aec19f25b6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a28d7f7e-82c1-405a-a637-ac63a5bfe3a6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a51fe804-97d5-4d70-a271-18a861efb05d"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a64ca568-3d9e-4305-9db8-b9cc98aa67c0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a6c6266d-c236-4f82-9fab-e2a9d3ce8f58"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("a8ac66cb-d032-4cfb-b0f4-a65d7877c87b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a985b8a8-5032-4fca-b5ab-cdaacf68f81d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ab206a63-cc2e-4dce-be4f-fb5c6a7bf691"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("abe41567-0ae9-4ee1-8447-86c842da7378"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ad527b15-1fb9-4a06-aad6-4faa1e71c8cb"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("ade5469e-d431-434e-b16d-3f52c0188586"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("aef303fa-78b0-4da1-ab2f-34733caa2487"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("af47c1ea-d900-45f5-a727-80ca46df62e2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("afec2f01-36f9-4a71-bb60-e9a40e32567c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b365c934-fbdf-46bb-826c-6e9ac4e0e3b2"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b3ccc277-f405-431b-81b9-1dfbbc2e0858"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b4e9880f-cc20-4e54-967b-5352d4645352"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b5fb95ca-b0d2-462c-9b3e-6ad288ca8a53"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b845dd47-8e70-4181-a284-96c3934cada6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("bd6f633d-d3ac-4e35-a1e1-fdba2a57706e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("be284b13-c90c-45bd-a9cb-d28970558504"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("be3ced5c-a95b-4b37-95b2-d4b659a6fa9b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c0bfd75e-b80b-4d0a-ac4e-733552022734"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c0fe3b61-9ee1-4263-aadf-abb975eb5576"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c3ec8b76-950d-4de8-9756-63e90c098d49"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c49a8bcb-55f8-40c7-81b0-ccea6a7590b5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("cb29043f-fa89-45de-839d-be442a9c5fd6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cce31fa7-6273-4e63-9854-768acbc4983c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ce65edbf-f138-4501-887d-feb62ac6a7f9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("cfadeea0-76b6-4e91-9003-ac614c543ddc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cff9b369-ff1a-4b96-ad66-32347b9e9b25"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("cff9d5e1-d362-4892-b1a1-612db8308528"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d1456548-4534-4150-a6b3-c3dad7cc3e85"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d3deb14d-3554-4e09-b56d-11596a159ba2"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("d5288eb1-2494-469d-bbc3-a5ee10e2fa63"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d5738091-2824-489b-b168-5cdf1179e598"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("d57432fa-9c9d-4d18-8771-74eb87db38c7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d6e1a2fb-6851-4f87-b5e3-6b91914a7438"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dce4b3a0-4384-41e3-9caa-1f583d8d04cd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dd0c3743-c24b-481b-b25c-778e0bb9910f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e05872c4-39ee-4b13-8dcc-dd3d113d1a90"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e24f010d-57cd-4d0f-9867-3fc205d5d743"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e4a87853-43dc-4554-b89c-9edf1dbd233b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e52761c3-3991-4d50-a6b3-9331770469a0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e70fa60f-0da0-44e1-bfcf-3e144d27cb45"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("e8d397ef-951a-4e65-a0bc-08cd526aadbe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ecbcfe20-e0e6-4273-9a5c-5a02cfe58469"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("ee51ef06-4732-486f-8ddb-a096bbaea1de"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f040beef-715b-4930-8a92-af03818d98d1"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f0624316-66f4-4379-bbfb-7983e88e5534"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f10d4872-68eb-4733-8b2f-6bf3ca74e76e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f4473770-983e-4280-9ebb-9d36ba512757"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f57d988d-fe2b-4b6b-8ad4-a35f4a63ab94"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f64dc30a-709e-4768-8bd8-7c54650bfbd4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f6508fc5-e4b9-46f1-927f-c60a9ec41ebb"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f6e52a33-0962-48a4-bb3f-69859f528b00"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f7b3126b-3cf1-418c-855c-30cc71f06f15"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f8f4fdaf-7982-4243-a398-fa3be569aec5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f937865b-2d9b-4f96-9a3a-e6cdb120dbc8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fbfd27ad-a896-4f17-bb6e-f59dab3dad0a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ff1eabb3-c210-49ab-8cc9-7c5578ce127b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false }
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
