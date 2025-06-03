using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentUsageHistories");

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "LastInspectionDate", "Name", "SerialNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 23, 20, 18, 4, 67, DateTimeKind.Local).AddTicks(746), "Sprzęt1", "SN001", "Sprawny" },
                    { 2, new DateTime(2025, 5, 13, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(3971), "Sprzęt2", "SN002", "Sprawny" },
                    { 3, new DateTime(2025, 5, 3, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(3997), "Sprzęt3", "SN003", "Sprawny" },
                    { 4, new DateTime(2025, 4, 23, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4001), "Sprzęt4", "SN004", "Sprawny" },
                    { 5, new DateTime(2025, 4, 13, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4003), "Sprzęt5", "SN005", "Sprawny" },
                    { 6, new DateTime(2025, 4, 3, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4005), "Sprzęt6", "SN006", "Sprawny" },
                    { 7, new DateTime(2025, 3, 24, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4008), "Sprzęt7", "SN007", "Sprawny" },
                    { 8, new DateTime(2025, 3, 14, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4010), "Sprzęt8", "SN008", "Sprawny" },
                    { 9, new DateTime(2025, 3, 4, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4012), "Sprzęt9", "SN009", "Sprawny" },
                    { 10, new DateTime(2025, 2, 22, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(4014), "Sprzęt10", "SN010", "Sprawny" }
                });

            migrationBuilder.InsertData(
                table: "Firefighters",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "IsActive", "LastName", "Phone", "Rank" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff1@osp.pl", "Imię1", true, "Nazwisko1", "123456781", "Strażak" },
                    { 2, new DateTime(1990, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff2@osp.pl", "Imię2", true, "Nazwisko2", "123456782", "Strażak" },
                    { 3, new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff3@osp.pl", "Imię3", true, "Nazwisko3", "123456783", "Strażak" },
                    { 4, new DateTime(1990, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff4@osp.pl", "Imię4", true, "Nazwisko4", "123456784", "Strażak" },
                    { 5, new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff5@osp.pl", "Imię5", true, "Nazwisko5", "123456785", "Strażak" },
                    { 6, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff6@osp.pl", "Imię6", true, "Nazwisko6", "123456786", "Strażak" },
                    { 7, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff7@osp.pl", "Imię7", true, "Nazwisko7", "123456787", "Strażak" },
                    { 8, new DateTime(1990, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff8@osp.pl", "Imię8", true, "Nazwisko8", "123456788", "Strażak" },
                    { 9, new DateTime(1990, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff9@osp.pl", "Imię9", true, "Nazwisko9", "123456789", "Strażak" },
                    { 10, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ff10@osp.pl", "Imię10", true, "Nazwisko10", "1234567810", "Strażak" }
                });

            migrationBuilder.InsertData(
                table: "RescueActions",
                columns: new[] { "Id", "Date", "Description", "Location", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 1, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(5178), "Opis akcji 1", "Lokalizacja 1", "Pożar" },
                    { 2, new DateTime(2025, 5, 31, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6265), "Opis akcji 2", "Lokalizacja 2", "Pożar" },
                    { 3, new DateTime(2025, 5, 30, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6278), "Opis akcji 3", "Lokalizacja 3", "Pożar" },
                    { 4, new DateTime(2025, 5, 29, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6281), "Opis akcji 4", "Lokalizacja 4", "Pożar" },
                    { 5, new DateTime(2025, 5, 28, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6283), "Opis akcji 5", "Lokalizacja 5", "Pożar" },
                    { 6, new DateTime(2025, 5, 27, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6300), "Opis akcji 6", "Lokalizacja 6", "Pożar" },
                    { 7, new DateTime(2025, 5, 26, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6303), "Opis akcji 7", "Lokalizacja 7", "Pożar" },
                    { 8, new DateTime(2025, 5, 25, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6305), "Opis akcji 8", "Lokalizacja 8", "Pożar" },
                    { 9, new DateTime(2025, 5, 24, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6309), "Opis akcji 9", "Lokalizacja 9", "Pożar" },
                    { 10, new DateTime(2025, 5, 23, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(6311), "Opis akcji 10", "Lokalizacja 10", "Pożar" }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 30, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8705), "Szkolenie 1" },
                    { 2, new DateTime(2025, 5, 27, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8935), "Szkolenie 2" },
                    { 3, new DateTime(2025, 5, 24, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8942), "Szkolenie 3" },
                    { 4, new DateTime(2025, 5, 21, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8945), "Szkolenie 4" },
                    { 5, new DateTime(2025, 5, 18, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8947), "Szkolenie 5" },
                    { 6, new DateTime(2025, 5, 15, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8949), "Szkolenie 6" },
                    { 7, new DateTime(2025, 5, 12, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8951), "Szkolenie 7" },
                    { 8, new DateTime(2025, 5, 9, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8953), "Szkolenie 8" },
                    { 9, new DateTime(2025, 5, 6, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8955), "Szkolenie 9" },
                    { 10, new DateTime(2025, 5, 3, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(8957), "Szkolenie 10" }
                });

            migrationBuilder.InsertData(
                table: "ActionEquipments",
                columns: new[] { "ActionId", "EquipmentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ActionFirefighters",
                columns: new[] { "ActionId", "FirefighterId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "FirefighterId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 3, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7096), 1, "Dyżur" },
                    { 2, new DateTime(2025, 6, 4, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7726), 2, "Dyżur" },
                    { 3, new DateTime(2025, 6, 5, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7736), 3, "Dyżur" },
                    { 4, new DateTime(2025, 6, 6, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7739), 4, "Dyżur" },
                    { 5, new DateTime(2025, 6, 7, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7741), 5, "Dyżur" },
                    { 6, new DateTime(2025, 6, 8, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7743), 6, "Dyżur" },
                    { 7, new DateTime(2025, 6, 9, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7745), 7, "Dyżur" },
                    { 8, new DateTime(2025, 6, 10, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7747), 8, "Dyżur" },
                    { 9, new DateTime(2025, 6, 11, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7750), 9, "Dyżur" },
                    { 10, new DateTime(2025, 6, 12, 20, 18, 4, 69, DateTimeKind.Local).AddTicks(7752), 10, "Dyżur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ActionEquipments",
                keyColumns: new[] { "ActionId", "EquipmentId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ActionFirefighters",
                keyColumns: new[] { "ActionId", "FirefighterId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RescueActions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.CreateTable(
                name: "EquipmentUsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsageHistories_EquipmentId",
                table: "EquipmentUsageHistories",
                column: "EquipmentId");
        }
    }
}
