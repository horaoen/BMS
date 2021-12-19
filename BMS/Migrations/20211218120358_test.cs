﻿using System;
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
                    BorrowerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
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
                    { "1b1bda49-6956-4943-8876-36b5f1b23eb5", "52dc302f-bfab-4981-8b01-c7a938162d3c", "Borrower", "BORROWER" },
                    { "a0cd2aa5-7a58-47ef-a415-62a39ca0e382", "6276966d-e45a-47ac-b7e3-04c7489a27cb", "Admin", "ADMIN" },
                    { "c50923d6-1a12-4b53-b8b7-0ab7ed6c3520", "de0dd465-6ecb-47f9-87ea-5aa932d7eeae", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fine", "LockoutEnabled", "LockoutEnd", "MaxBooks", "MaxDays", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e74c43d-0ebc-4f0c-a8db-39b441f1e094", 0, "a5822c84-16c2-4bad-a633-d7e410446865", "bleso624@gmail.com", false, 0, false, null, 0, 0, "BLESO624@GMAIL.COM", "BLESO", "AQAAAAEAACcQAAAAEIusESoUBGufHZkn6GdHmdQ7C05m6NmmEo7Tgg1SjkU3KPYcP3n/Veowv1EPrRN80w==", "15137667148", false, "0808c321-034b-4b3c-8942-7e677a45368a", false, "bleso" },
                    { "3153ec95-3327-45fe-a621-fd94d0ce0e8e", 0, "556c8243-18cb-4bdb-a5f7-468ae94cdb6f", "horaoen@gmail.com", false, 0, false, null, 0, 0, "HORAOEN@GMAIL.COM", "HORAOEN", "AQAAAAEAACcQAAAAEDbSQdht4i5yW2d/HZE0K5CLYZGw2kr4oXqeLst6pQEMXW8kplSO9tMC+kzrUK68sA==", "15137667148", false, "95728186-bba8-40cc-a276-fb520cfa6557", false, "horaoen" },
                    { "799ecd90-a085-42dd-bb49-7a8079601468", 0, "b7655000-beea-4ec1-b527-e84a9e9699c3", "2495644988@qq.com", false, 0, false, null, 0, 0, "2495644988@qq.com", "FHR", "AQAAAAEAACcQAAAAEJrTtt+GYId3GUDjZ6p0BIYTxv7+6Vibsv2TFPURxYw6klEtVWqfKFsmi5EBKYjgUw==", "15137667148", false, "44ffcb41-b9bb-48de-91b1-861b0d201062", false, "fhr" }
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
                    { "a0cd2aa5-7a58-47ef-a415-62a39ca0e382", "2e74c43d-0ebc-4f0c-a8db-39b441f1e094" },
                    { "c50923d6-1a12-4b53-b8b7-0ab7ed6c3520", "3153ec95-3327-45fe-a621-fd94d0ce0e8e" },
                    { "1b1bda49-6956-4943-8876-36b5f1b23eb5", "799ecd90-a085-42dd-bb49-7a8079601468" }
                });

            migrationBuilder.InsertData(
                table: "BookTitleItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("015a7f30-393d-45fb-87e8-a9c74d5cba3f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0222989a-be68-43e7-8c0f-dfaa2ae07465"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("02666b7f-374b-4319-b9c1-d011cfe53390"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("0320e767-91e8-42e7-9345-25e6303d9df0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("03b013d2-4ed6-4997-8359-c25889ac8c80"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0409031d-0eb2-4443-87f5-9f0ae79295cb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("07bbc311-9b29-4422-b0eb-0dac50439b2a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0851e031-0cd9-4779-9f97-88eb1c072b9f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("093783f8-e186-43c9-9727-4e0d522b1d40"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0ba10ef0-60c0-4351-9f99-774a46731e1d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0e8290a6-6563-403b-aaa0-ea212f6724bc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0f24a3bb-7f85-4a04-abd9-58489d8488a3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("0fbdfae1-ea3e-4fec-aaa8-c13adf655802"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("13de5023-2290-4e99-adb1-bc729f267a2c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("13e0cd97-a228-4917-8eb2-8e5bbe6bf592"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("1796f2a6-231c-4635-b1b4-73e626065263"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("1830e33d-ee0d-4935-a8f5-a0558ef8ceae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1983ef50-c8b9-4b75-9ea8-2915f8406e28"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("1a9771b7-a980-4cc5-bcdb-1d5ee0b4ac96"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("28a856ac-ac10-4707-b0a3-1165ee597257"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("293423dc-0b6c-46a2-b35b-8057999b9633"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2a08a465-ffd2-4f48-be10-acd966ceb213"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2a8823de-fdff-4453-979c-967f6502e866"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("2ccb2400-9b7d-49cf-9b18-4b27155a9cbd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2d632392-7e8b-41cb-8947-d1e94bd755b1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("315bc17a-2089-47ce-87da-3f496a5f78e5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("36d976e7-a6f4-48be-a469-7dacbca1a273"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("37235db1-bb5e-4329-91da-3a5b0eead5b9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("392349c4-b5ac-45e2-ad16-eddc14271fd1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("39e7fc28-59cb-4c72-aa7e-63e7f66ef049"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("3b54f5fc-b447-4f62-8f1c-4a3de743a5b5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3bae1291-e281-45a9-95b3-bbf5841c6c7a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("40af3d5f-a21a-4817-95a1-4e74a57ef1d6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("42fd10b0-1a0e-4d9b-8a92-a9c4b2462117"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("448b9cb0-8586-4d9f-8d0d-ca1272b27552"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("45d2e4f1-9562-4912-bea2-2c3b2dd75d7d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("46a36976-2eea-4945-b388-4e05b5d0d887"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("48674f9d-09c2-4317-aac8-7d531fdae413"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("4cc7f0f0-58ed-4151-944b-742804359bff"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("55009ba8-8bd9-405e-a325-2b5070bcaeb6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("5532696d-e576-4078-8e83-766be1d09780"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("55c7cfb5-00b4-42c2-8709-aef1ad264ea1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("58c4e35a-7c1b-4cd4-a930-8e91be1da612"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5ae25ba0-d2c6-4346-875b-56bad063e2f9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5e3a8d5b-2c40-4e47-9d4c-813c2c2f3670"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("5edf5a59-cd56-43ed-84e1-98c75f8914eb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5f740d5a-a720-4b6b-ac74-6208c8643e4a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("60d5d103-13fd-4469-9268-d278edb34458"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("63b6666d-8f1a-4180-98f8-91c8c2c20df0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("643c0776-4096-423f-97ea-2aa838cafad3"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("659f80a7-e3ae-4449-b955-0972a0e835a7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("66846445-249d-4f6d-b839-2cd7997487d5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6c083aab-4e61-4482-ac0b-22b16b0d0501"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6faf0e4a-5758-463a-9e19-dd23aa8baa78"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("71bfe107-5fb1-4573-bd0c-cbf8dcee1ca2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("74278a72-0628-4405-a259-2bd185503651"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7579e0ac-ae51-45f2-86e9-7c6776883c7a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("76ba34a7-ec1d-4bc3-8a07-81162e95d4cc"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("771798cb-5f9b-485f-9bd1-6ae6b5eebb96"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("7728756f-0b49-4a63-958a-cfc8c29ea924"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("77db277b-13df-40e1-8f38-a656a99218c0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("78466e32-6527-4caa-820a-8cd72ed5760f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7865f2be-4227-419d-8a73-ecb333529f85"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("7a8e6599-23f7-4402-8e21-3abb90ab8dc3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7cfd55f1-6673-42d8-9198-9ecc52fdc494"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("7de8e23f-58f8-4622-bb46-2567e75245d0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7ee58db7-b408-4527-871b-f2e8a8ce983a"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("802f05d4-3aba-4206-90f0-680e721eed4e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("807f9116-9b8b-49ae-9888-60064675c45a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("829b10c0-e041-4a71-8340-412b4df76e7c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("831eff66-19c1-4563-a159-37425358375e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("837e557c-6a2c-4448-b0fc-e1f653a91348"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("838d6384-af10-45ba-96bf-b8df42e162fe"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("83b5cb2f-e637-406e-b066-4deabafdb4a6"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("86c42174-8c19-42fe-b1e7-6f92a9373be7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8724e722-98f6-4be7-8bde-5b3b612f6c60"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("878a21cf-960e-4785-b657-179318a8e961"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("87cf4969-a869-472a-8e49-f3a2336f261b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8ade75c0-cd7d-4564-89c1-d1c120fb3a5c"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("8afe6808-c9f4-4c4d-9249-0011c93fe5fd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8b7b259a-838a-42d7-9f38-13dcad90eb32"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("8bf458e2-d16e-4326-b44b-8e24be9e3ae4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8cda4c00-4140-4c24-9221-8d0ce7b873e0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8d23abda-abea-4cb9-b1c1-7a8da7893f47"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("8e3b9988-151e-4d7b-a6c8-5d401880505f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("90ceab6f-435f-4160-be09-71434523d379"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("90e3ca5a-d5ba-4a79-96d3-f578b9bfaeed"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("9102dbd7-8c83-4dfb-a718-ceb98fe9cfc7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("93cd1992-e430-4b89-b18f-6db013e2cb45"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("976566e3-ab9a-4daa-a685-fb7fc325c5ea"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("9a1a1ec7-db8e-405f-af11-409122026e26"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9f5ac919-0dbb-4ce9-935e-debec131ba43"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a130e052-3dc0-40cb-8dcf-e76b824f8cf4"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a1cac999-f5e6-4cd3-812d-1bba148a6c84"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a740c2ee-ab2c-4d36-8aeb-c3fa32968fd3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a7ae16b5-2303-4ef7-aa87-add236535266"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("a9d7c7fb-ceb5-42d6-812a-135c1990601a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("aa0e43d3-5eff-4b3e-80ff-e8e44899dbac"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("ac1d5b07-ac01-4501-9c46-b7ea228f72e1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b1106100-ffc9-4262-bd80-5b13d0d07fb6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b1a4bda5-ac4d-427c-a91d-ed35abeda529"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b1eb67da-a143-49eb-8c05-b1dbe2a05f63"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("b246b97f-04b2-4182-8392-9063a6a58366"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b2bc5281-a540-4f7e-bdbb-90e58672ceba"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b30597c5-cc56-4b72-9931-b2004a11f8af"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("ba1b81e8-b532-49ef-b2c3-cc8d3c39c36c"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("bc00ba8d-ecaf-4540-a923-2b78947bd705"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bd274710-ec52-427e-bfed-7cae35c32591"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("be717a03-c470-46a6-835a-ec8238aa55aa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c2d651e8-b64e-4491-943a-2029752b737c"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c39c7a27-173e-46d4-a23e-f40f914d41a5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c477d53d-0170-4af6-bb79-6ab0350ea550"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("c49ddd1a-9499-4658-8521-ec88cc3ca937"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c65b73ef-9440-46d6-91bf-dd8ba082a64a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c73d2e2c-0fe6-4ec7-ba0b-003310a854e3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c98df964-2980-4282-a0bd-2b3e1fe32bb0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c9a480f9-337d-485b-ab8f-53bfc0e24953"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cd3a68dd-408b-4fa1-8de8-da40dfd3ffc8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cf7c2fb1-08c1-4113-a1ea-d115bdcbbb60"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d0d186c0-6ce9-475a-9d6b-2f8e2b4eeaec"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d156a35d-03e5-43da-b295-aa78ba6d0325"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d22a9834-655e-4df3-9a57-beeed6a824b0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d2362783-aad9-4ce6-b58f-b9e3f9098bc0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d4bb30fc-3658-4112-9a2e-4efacaa548f8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("d5f26f5d-3f5b-47a2-975f-e22151937c84"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d60dd173-529b-4979-a131-84009a160619"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d6e59087-47d6-44da-a31f-44f8beeea6e5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d77cd41e-3a13-446f-8380-0563ae6cf180"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("d7f8293b-6b28-48a7-85cd-908652a482b3"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("df084b07-a9de-4c9b-a5d5-56016ad6923a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("df66eed5-4e1d-40bb-a9d4-f35f69adb11e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e0b0e00b-6c6e-41fa-bd19-a5ac91fa8bab"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e0f44dfc-a2b5-41fb-b78d-d1214b43f1f1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e27dfb3d-6d8a-4f40-889d-c4c54dc3aefb"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e608364d-a352-48b5-b861-a14584f107c4"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e7638615-34d7-48b6-8424-cfffd6882721"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e7689d99-8546-4d0b-b6c8-7282a9ed2ee2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e79c3eb7-4ade-4d87-9a39-4ebec290838a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e98205dc-a2b3-4267-bafd-0dfe878b12a8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e9a09ca8-bf3a-465b-ad01-e983a33be72b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ea31e741-5495-4817-b525-f69d81d87f1b"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("ebc8d11b-aa20-494e-93eb-33038eb4d001"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ef781799-2eae-4f78-90d0-51b6a48bf8bd"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("effb3060-da50-4649-bee1-845894e63150"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f5305300-b8a6-4b1e-85e2-f3e14e6a0dba"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f5971884-cb88-41e9-bc7c-989c09bc5624"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("f5dcfb16-86a4-4e53-b6b6-5064532e2502"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f60fb8c6-ec93-48d8-914f-1f56bf4f351c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f7698c9d-effa-42d4-937f-79b6a0647a6c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("f7d20243-30ca-41c7-93f6-9b3f67d58156"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fa66cf60-057a-4a3b-bba5-508c783030aa"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("faf6b3ae-31e6-4092-9175-ffb674ef71ad"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fafd57f7-e74a-4e84-b7f6-57883b59494b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fb494480-880a-470b-8a05-589be1d36306"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fb927d6e-edc6-4b3a-b2b3-81f308369409"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fbf33544-ace9-453d-b949-e7b8cc80e3c7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fc835500-df20-4f1c-a486-ad743a0c7ddc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("fdd0cbc9-2028-45c4-839a-00e39b48e2f6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ff52a7da-f7e7-4b00-869a-1f24740b0aac"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false }
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
