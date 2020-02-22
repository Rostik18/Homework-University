using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApplication.Migrations
{
    public partial class AddTablesAndConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditTitle = table.Column<string>(maxLength: 30, nullable: false),
                    PercentType = table.Column<int>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    PayoutPeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepositTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepositTitle = table.Column<string>(maxLength: 30, nullable: false),
                    PercentType = table.Column<int>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    PayoutPeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    BirthdayDate = table.Column<DateTimeOffset>(nullable: false),
                    RegistrationDate = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "getutcdate()"),
                    EmailAdress = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 13, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    MoneyCount = table.Column<decimal>(nullable: false),
                    IsFrozen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankAccountId = table.Column<int>(nullable: false),
                    CardType = table.Column<int>(nullable: false),
                    PIN = table.Column<string>(maxLength: 4, nullable: false),
                    ExpirationDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditCards_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCredits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankAccountId = table.Column<int>(nullable: false),
                    CreditTypeId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "getutcdate()"),
                    FinishDate = table.Column<DateTimeOffset>(nullable: false),
                    StartSum = table.Column<decimal>(nullable: false),
                    DebtBalance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCredits_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCredits_CreditTypes_CreditTypeId",
                        column: x => x.CreditTypeId,
                        principalTable: "CreditTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDeposits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankAccountId = table.Column<int>(nullable: false),
                    DepositTypeId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "getutcdate()"),
                    FinishDate = table.Column<DateTimeOffset>(nullable: false),
                    StartSum = table.Column<decimal>(nullable: false),
                    CurrentBalance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeposits_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDeposits_DepositTypes_DepositTypeId",
                        column: x => x.DepositTypeId,
                        principalTable: "DepositTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_UserId",
                table: "BankAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_BankAccountId",
                table: "CreditCards",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCredits_BankAccountId",
                table: "UserCredits",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCredits_CreditTypeId",
                table: "UserCredits",
                column: "CreditTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeposits_BankAccountId",
                table: "UserDeposits",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeposits_DepositTypeId",
                table: "UserDeposits",
                column: "DepositTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "UserCredits");

            migrationBuilder.DropTable(
                name: "UserDeposits");

            migrationBuilder.DropTable(
                name: "CreditTypes");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "DepositTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
