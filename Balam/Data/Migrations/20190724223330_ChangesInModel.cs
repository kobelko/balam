using Microsoft.EntityFrameworkCore.Migrations;

namespace Balam.Data.Migrations
{
    public partial class ChangesInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApportionInstalment",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "ProvisioningIncluded",
                table: "Quote");

            migrationBuilder.AddColumn<decimal>(
                name: "ApportionDays",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Cleaning",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "DaysPerMonth",
                table: "Quote",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "DriverTravelExpenses",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DriverWage",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Fund",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "GasMileage",
                table: "Quote",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "GasPrice",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Instalment",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Maintenance",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OtherCosts",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Parking",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Passengers",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PhoneLine",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Provisioning",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProvisioningDays",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TargetProfit",
                table: "Quote",
                type: "decimal(6,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Taxes",
                table: "Quote",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApportionDays",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Cleaning",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "DaysPerMonth",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "DriverTravelExpenses",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "DriverWage",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Fund",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "GasMileage",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "GasPrice",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Instalment",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Maintenance",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "OtherCosts",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Passengers",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PhoneLine",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Provisioning",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "ProvisioningDays",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "TargetProfit",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Taxes",
                table: "Quote");

            migrationBuilder.AddColumn<bool>(
                name: "ApportionInstalment",
                table: "Quote",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProvisioningIncluded",
                table: "Quote",
                nullable: false,
                defaultValue: false);
        }
    }
}
