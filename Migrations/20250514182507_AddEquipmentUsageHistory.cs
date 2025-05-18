using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipmentUsageHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsageHistories_RescueActions_ActionId",
                table: "EquipmentUsageHistories");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentUsageHistories_ActionId",
                table: "EquipmentUsageHistories");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "EquipmentUsageHistories");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "EquipmentUsageHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastInspectionDate",
                table: "Equipment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "EquipmentUsageHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "EquipmentUsageHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastInspectionDate",
                table: "Equipment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsageHistories_ActionId",
                table: "EquipmentUsageHistories",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsageHistories_RescueActions_ActionId",
                table: "EquipmentUsageHistories",
                column: "ActionId",
                principalTable: "RescueActions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
