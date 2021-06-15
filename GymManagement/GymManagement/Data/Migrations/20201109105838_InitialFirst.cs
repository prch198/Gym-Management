using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManagement.Data.Migrations
{
    public partial class InitialFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    EquipementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eqname = table.Column<string>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.EquipementId);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(nullable: false),
                    details = table.Column<string>(nullable: false),
                    amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "Plans");
        }
    }
}
