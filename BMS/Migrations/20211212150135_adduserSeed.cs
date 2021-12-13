using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class adduserSeed : Migration
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
                    Borrower = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
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
                    LoanDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                    { "5d5fcf5e-1619-4a58-bef7-ecd31fd9a38e", "eb14fbfa-823f-4687-8a92-9665573bd1d6", "SuperAdmin", "SUPERADMIN" },
                    { "d2c594b2-3a84-4d28-9639-44549de6d704", "461aec14-3637-46c9-bd21-2c4b2a5adb03", "Admin", "ADMIN" },
                    { "e1badac2-52ef-46b6-978c-de38ca1490c9", "681dbdfd-7e32-48f5-be6a-009266384216", "Borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MaxBooks", "MaxDays", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aab6762a-a10b-48b2-bd6c-14d7be4548eb", 0, "df6a50fb-0778-4f2b-837e-ba821dcfc789", "2495644988@qq.com", false, false, null, 0, 0, "2495644988@qq.com", "FHR", "AQAAAAEAACcQAAAAENiEE9uUNd/PHYrX+7DSK8MbLeLHI/EhFDeF7SXFbU/G/WuyAzKNO2FKlDpWJZhPwA==", "15137667148", false, "1d8a312e-8e52-4e2c-b951-ff16862d5a47", false, "fhr" },
                    { "ede90e59-9ab5-44f1-a7f3-74ae3e23379e", 0, "299b58ff-8688-4384-9fd6-e143d4e1c061", "bleso624@gmail.com", false, false, null, 0, 0, "BLESO624@GMAIL.COM", "BLESO", "AQAAAAEAACcQAAAAEEWgIl12qUjaUiJMvexxWqqj9mB9lIwKtYJW/xyLao5LQOrEZRfNgdNx3WZGa+SGWg==", "15137667148", false, "2d51c663-db88-4eda-8300-37a96e2efa8d", false, "bleso" },
                    { "fbae1800-3f60-497c-b66a-723b83c06915", 0, "074a4e18-4fac-4cc6-9658-bd46ecbab6fc", "horaoen@gmail.com", false, false, null, 0, 0, "HORAOEN@GMAIL.COM", "HORAOEN", "AQAAAAEAACcQAAAAENQLU/plCP8JDTCUYFKT8ojQlkN/3E96dTOMdMgjzhxQv+tkIRhO9jtE7HnpRYEKPg==", "15137667148", false, "6db73cb7-50d8-4d9d-abce-d50076103033", false, "horaoen" }
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
                    { "e1badac2-52ef-46b6-978c-de38ca1490c9", "aab6762a-a10b-48b2-bd6c-14d7be4548eb" },
                    { "d2c594b2-3a84-4d28-9639-44549de6d704", "ede90e59-9ab5-44f1-a7f3-74ae3e23379e" },
                    { "5d5fcf5e-1619-4a58-bef7-ecd31fd9a38e", "fbae1800-3f60-497c-b66a-723b83c06915" }
                });

            migrationBuilder.InsertData(
                table: "BookTitleItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("02780bc3-f94a-4e54-855c-e15f618a5037"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("03565f88-dd7c-4dad-a0ae-5e8df53580c6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("041a47f5-3653-4ecc-a0fb-e5a4cf3fcad6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("046cd425-72d1-459a-b3b5-1bd2912e13b0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("04f29239-d0f1-410a-bd0c-967bdfb8fbef"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("06d90e7e-c09a-4ffa-b330-f698162696ce"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("094b6460-82cd-4a66-b724-86d1390edf45"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("09819962-012d-4222-90f9-c9fbc087bd43"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0dd85a15-6358-4072-b853-78ca54e00308"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("12e4b2c4-7712-412c-b61e-5ce72e8f7a49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("12efe4aa-ca0a-4b01-8fdf-6f31ee3204b7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("13df2e93-e0c0-4952-9bf7-0043492cd4f1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("15fade52-9783-4294-be0b-015857029278"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("16b1a86b-1478-4487-9517-81f9fe4ac349"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("16baa191-1935-4b71-b723-e60a082d2944"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("188b0d0f-0b05-460c-9b3e-b1c03652e187"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1a41fec2-f12a-4143-a010-e57f8975b695"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1b0919ec-3b24-458b-bd37-2df6cba4399d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("1c31ec8b-2500-417b-97d0-09f62ebedeb8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1cd3a199-eebb-4d75-8d7b-74bf54171a24"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1d0728b1-9376-4370-8862-9a818365b6fe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1dab887b-ffba-4b0f-bacc-4dcfd4e416b6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("20a05dd9-f21c-47bb-9dea-0bb2352b83e8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("20de28ec-bed9-4fa2-a979-725eaaef87a9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("232a5600-9e7a-4892-a1ad-224128625d39"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2582af07-e384-4da4-a993-8e873b46e2fd"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("258751ad-4abe-44eb-a538-87e3010f7c39"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("26a6909e-4e13-4206-aa14-5357a066f81a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("285e09eb-5c40-44b9-9e0d-1bcb5de24e4d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("298f9194-bcc7-4d6f-b2df-15917db3ce49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("29e95eff-6b5f-4c19-b81c-f5cb26691565"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2aaa85db-d80e-4147-8e33-f7ae448d3c80"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("2b3dd895-24bc-4d79-8739-46839765dfd9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2c479fdc-3e32-4253-8304-ef4bd184d16d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2cf8af3e-b9dd-4656-8ae8-acc8a4ef20a8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2e0a6217-7878-4c63-8cef-83c1b8bc4b73"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2ebc0dc8-b940-4f1a-87fc-6351c9dc7082"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("300d6dea-f23d-4f05-88f0-89f000f3c2ce"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("35d9d13e-4902-4e94-a6e7-293f9edb1e1e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("37054619-ed9d-444c-baec-02498ae6c767"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("381d3059-733c-4e66-ac88-1a1e76b7319a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("39309464-45f0-45ba-8546-d3bbdd263c53"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("39da82c3-624a-4bf2-9c9f-b7a3c89f0e47"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3ada5d02-2612-48cf-8edc-7f4db3ac805a"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3ae27868-df0e-4e52-b293-5e72a1fa02cc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3c027cf7-4240-4367-bbf6-9273fe06ee4f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3c138078-56b6-4b80-bcd4-beeb542c69fe"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3d4d6990-b9fd-4f17-9592-cedc08649523"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3e6d5a7e-97bc-406b-a83f-8e28dc0bc609"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3f602bb8-fe92-45f3-8572-100492c646f9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3fb614cb-b664-4c2e-9d7b-25e8501b198f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("449097ff-822e-44a2-89df-b6e6ed27677e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4d3c296a-5b4e-420e-9c08-e3296decd66a"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("4e775b6c-f1d3-4ade-af06-18841578e4ee"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4f6f051c-f119-44cf-b86d-1f1cf96a90cd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4ff91018-59df-4c07-8b26-1f44a6ef564d"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("56808d21-845e-454c-b438-2dc566402665"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("57b8e687-71ae-4882-87e4-2de42f272733"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("58516e0a-a7d5-4ed7-8ff2-3de09d42442e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5cf27ef7-724a-4825-bca0-45e588f53c55"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5fdccd7e-4059-4455-bbcf-bf8c3b29d9af"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("609d254b-ccfc-42ab-9316-0a07fe4b4047"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("60c90e27-7d36-481f-a017-f579e3a22295"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("610e864d-ab18-401d-ae7e-e0c72150c474"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("67329e24-2cfb-4440-80e8-ed8a902baddd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("69d8e949-27f7-4a12-a500-f17c5f91a525"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6be0b40c-c166-46a2-b90d-39df4ad78743"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6ded4ae3-8b36-414f-8370-21450e6e7905"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("70e6c2ae-0cb1-4663-b920-7aa57a302ca1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("730235c7-57cc-4a1f-97b0-260e0ba909c6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("73f990a2-c621-459b-972e-df1a6dbc1a74"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7408a6b3-11a6-4070-8533-173fa3949884"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("75110893-46f1-49e6-875b-ff41a6cafb65"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7675cdb6-30ea-4ca1-8765-53323448c84c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("77175474-472e-427b-b86e-5a84f01b24cb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("786f1b23-a080-4a41-aa2c-a09061a6ab6f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("78f7239f-e0f7-40f3-9331-7eff84ec1e55"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("7aa5496b-09c0-453e-a46d-a6c4aa957b1f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7e41746c-1eed-4368-9f6f-794a4650e127"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7e5574f5-542e-414b-b19d-df8d0305677a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("82b35a07-3e1f-4e5b-ac06-d62d7b8df721"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("8349a772-bf61-4d4b-8bc0-bc07021cd413"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("84575b2b-1958-4e61-857d-b122dd2d851f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("8537f5d7-1dee-425e-8c41-9c90d1116af0"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("854c9677-48ca-453c-ace3-cd83793e481a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("854fe0cf-e0cc-417f-9dcd-038d715f7d86"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("898547cc-35aa-4eb2-aa88-3717e6ffe462"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8a543e92-b9ce-436e-a488-1df60c2a3568"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8a873b29-b0c5-4f81-8074-bc4e6e8bf6a9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8aa5939f-932b-4555-a860-4dfcd8eebd9f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8b4cbf6e-8b28-48a9-bc14-d139486ff1ee"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8bf4a6c0-b5f9-4914-b047-24f8cfb8df62"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8f4e2495-ae7a-4d6c-827d-db6aaeffb6fc"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("90c81cd0-8353-434b-b477-9842bf7f0dbb"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("90f0e22c-9ab7-48fe-aaa1-e3870eb8ca39"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("921fc3dc-bd27-43da-9dcc-5b8ef15489e3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("923f541d-72ee-4431-b900-371f17ca4a78"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9300e2bb-de72-42b8-a333-3d4719afb8fe"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("9694ce9b-4681-4b76-8322-57fb82105f61"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("97df6f11-cded-400b-a350-e26fb87f255c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9999e404-a7c0-43eb-8124-fa4f7aa1da37"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9ab89604-f0ee-4050-863c-d6f0e437af48"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9d1754fc-fd8a-4fe2-9439-1d05e27a3eb4"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("9d51ad29-a892-4b5d-b0cb-ee21cf4ea397"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a1536faf-a3cf-4cfe-821e-48a3082b1252"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a38b3d9b-b6c9-4d76-8b80-2d734bca9773"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a4f21b93-b9b8-4662-a7b5-39223961b775"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a598aedd-8d34-4f15-b84b-4ec109b3ea83"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ac121304-9c17-49ab-aceb-e7cf624c72b2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("af64323b-86e1-4b88-8372-aa4ea2177013"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("aff32c8b-2796-4040-97a3-9c4470c1e95c"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("b2dc1f19-0056-4eb3-a660-322f62339e14"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b8217fd4-e941-476d-91e2-8e00625b614f"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("b8adcbdf-d70b-45a1-bfe6-b5c21ba405cc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b9d84a94-5bc7-40d1-858b-a66689d01d5e"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("ba056c0f-93b5-4a14-8ba9-fc77c0c1fd6e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbc970eb-8c73-4234-9cb8-a28ae355d944"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbccca50-fc62-4bd4-9006-64d52d356c1e"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("bd2af875-aabf-4a56-8e68-462134405691"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bd57f19d-6ea0-4cf2-b189-374a554da0a7"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("bdca04cb-ad79-408f-99a9-f34ac5915f6e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bebd1f56-177d-4d95-ae74-c72b8a38f3a4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c37aa2ea-68ab-47ba-986e-a3dd119b8d7d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c52b00c2-70c5-401a-8e18-37839e03372b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c75bbff4-048c-4c56-97b2-9f5f13a15c95"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c769e604-e0ae-4042-bb01-3f561a1d3e68"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ca111aa7-0bb2-4585-a3f6-5b3702e9e2bc"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ca666fd9-40f8-40ca-a509-b7835cba7c7f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cc156dc3-c638-4886-9f41-09b332b16db7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ce29fdee-5dbb-433d-b8a9-98fa95cbd84b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d21ed9a2-a924-4f85-9b4d-b939ecab3ba6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("d497461d-8063-4eab-9233-3e22af8ec771"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d5f117a8-5067-40a7-92f5-671e3ded031e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d73bf2a1-6886-4fb1-a594-2c2f3df7ea2e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d7f49522-2529-4e6b-aad2-0d2704b536c8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d87e5db4-f258-4fb3-b647-185c88a6fe62"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d89ac6d1-bde3-4be5-adeb-a4c82931908b"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d91dc8dd-2e33-4736-9219-f0280a003ae8"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d9372b35-f74c-458e-955d-94ee483c0856"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("daa76c3c-84cb-4259-bea4-852c801b1f9f"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("dfe57531-76e0-4096-a6b8-e8546ae99895"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e0e74010-9f33-4206-855c-cff215366902"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e1b22a02-9816-4125-9939-9fef899b2350"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e5c4cde3-1e35-42cb-9a6f-05603c026c99"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("eb0580c1-9892-4a2b-9910-8c5af8bc01cf"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ecf2a47e-5868-4cff-903b-814924d0b3db"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("eef360d0-32db-4492-bfd8-ddb7277fe56c"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ef76072b-2772-403c-b685-46b76310c516"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f102223d-27ee-4665-a990-5643bf230f89"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f20e9af1-39f3-48fb-8dfa-73769764bc65"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f25d8a78-4f6c-4c4b-8f5c-a0b568a0309d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f2717147-8458-4fd9-911a-42074c1055f8"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f421aa0c-f57b-4171-a5e1-4f980e0c936d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f42926a1-5c3a-46c2-b295-21b685de4358"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f5b309be-08fb-469f-8e93-e23cba2006f2"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f9079244-c795-4a52-b514-f646bc06da13"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f92640cd-4efe-4dad-91b0-2687ff03f0b7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f9df81a2-5d60-4d30-8bad-dfc6141ef221"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fb10024d-404f-4bcd-851f-8ebac3b2c93d"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false }
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
