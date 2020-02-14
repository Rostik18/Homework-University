using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApplication.Migrations
{
    public partial class AddIsPaidToUserDepositsAndCreditsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "UserDeposits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRepaid",
                table: "UserCredits",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "UserDeposits");

            migrationBuilder.DropColumn(
                name: "IsRepaid",
                table: "UserCredits");
        }
    }
}
