using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddFullStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastInspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RescueActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescueActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirefighterId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Firefighters_FirefighterId",
                        column: x => x.FirefighterId,
                        principalTable: "Firefighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionEquipments",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionEquipments", x => new { x.ActionId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_ActionEquipments_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionEquipments_RescueActions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "RescueActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionFirefighters",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    FirefighterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionFirefighters", x => new { x.ActionId, x.FirefighterId });
                    table.ForeignKey(
                        name: "FK_ActionFirefighters_Firefighters_FirefighterId",
                        column: x => x.FirefighterId,
                        principalTable: "Firefighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionFirefighters_RescueActions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "RescueActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentUsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    UsedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentUsageHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentUsageHistories_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentUsageHistories_RescueActions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "RescueActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirefighterTraining",
                columns: table => new
                {
                    FirefightersId = table.Column<int>(type: "int", nullable: false),
                    TrainingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirefighterTraining", x => new { x.FirefightersId, x.TrainingsId });
                    table.ForeignKey(
                        name: "FK_FirefighterTraining_Firefighters_FirefightersId",
                        column: x => x.FirefightersId,
                        principalTable: "Firefighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirefighterTraining_Trainings_TrainingsId",
                        column: x => x.TrainingsId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionEquipments_EquipmentId",
                table: "ActionEquipments",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionFirefighters_FirefighterId",
                table: "ActionFirefighters",
                column: "FirefighterId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsageHistories_ActionId",
                table: "EquipmentUsageHistories",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsageHistories_EquipmentId",
                table: "EquipmentUsageHistories",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FirefighterTraining_TrainingsId",
                table: "FirefighterTraining",
                column: "TrainingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_FirefighterId",
                table: "Schedules",
                column: "FirefighterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionEquipments");

            migrationBuilder.DropTable(
                name: "ActionFirefighters");

            migrationBuilder.DropTable(
                name: "EquipmentUsageHistories");

            migrationBuilder.DropTable(
                name: "FirefighterTraining");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "RescueActions");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
