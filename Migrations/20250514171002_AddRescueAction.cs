using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddRescueAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RescueActionId",
                table: "Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FirefighterRescueAction",
                columns: table => new
                {
                    FirefightersId = table.Column<int>(type: "int", nullable: false),
                    RescueActionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirefighterRescueAction", x => new { x.FirefightersId, x.RescueActionsId });
                    table.ForeignKey(
                        name: "FK_FirefighterRescueAction_Firefighters_FirefightersId",
                        column: x => x.FirefightersId,
                        principalTable: "Firefighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirefighterRescueAction_RescueActions_RescueActionsId",
                        column: x => x.RescueActionsId,
                        principalTable: "RescueActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_RescueActionId",
                table: "Equipment",
                column: "RescueActionId");

            migrationBuilder.CreateIndex(
                name: "IX_FirefighterRescueAction_RescueActionsId",
                table: "FirefighterRescueAction",
                column: "RescueActionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_RescueActions_RescueActionId",
                table: "Equipment",
                column: "RescueActionId",
                principalTable: "RescueActions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_RescueActions_RescueActionId",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "FirefighterRescueAction");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_RescueActionId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RescueActionId",
                table: "Equipment");
        }
    }
}
