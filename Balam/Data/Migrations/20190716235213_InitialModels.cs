using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Balam.Data.Migrations
{
    public partial class InitialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Days = table.Column<int>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Toll = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GasolineIncluded = table.Column<bool>(nullable: false),
                    ProvisioningIncluded = table.Column<bool>(nullable: false),
                    DriverIncluded = table.Column<bool>(nullable: false),
                    ApportionInstalment = table.Column<bool>(nullable: false),
                    CalculatedCost = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CalculatedPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    FinalPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Profit = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    CompetitionPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DriverWage = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DriverTravelExpenses = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Passengers = table.Column<int>(nullable: false),
                    TargetProfit = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    Provisioning = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DaysPerMonth = table.Column<float>(nullable: false),
                    Cleaning = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Maintenance = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Parking = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Fund = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Instalment = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PhoneLine = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GasPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    OtherCosts = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GasMileage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
