using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddRescueRelationToEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_RescueActions_RescueActionId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_RescueActionId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RescueActionId",
                table: "Equipment");

            migrationBuilder.CreateTable(
                name: "EquipmentRescueAction",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    RescueActionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRescueAction", x => new { x.EquipmentId, x.RescueActionsId });
                    table.ForeignKey(
                        name: "FK_EquipmentRescueAction_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentRescueAction_RescueActions_RescueActionsId",
                        column: x => x.RescueActionsId,
                        principalTable: "RescueActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRescueAction_RescueActionsId",
                table: "EquipmentRescueAction",
                column: "RescueActionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentRescueAction");

            migrationBuilder.AddColumn<int>(
                name: "RescueActionId",
                table: "Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_RescueActionId",
                table: "Equipment",
                column: "RescueActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_RescueActions_RescueActionId",
                table: "Equipment",
                column: "RescueActionId",
                principalTable: "RescueActions",
                principalColumn: "Id");
        }
    }
}
