using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSPManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), "jan.kowalski@osp.pl", "Jan", "Kowalski", "123456789" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1992, 8, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), "anna.nowak@osp.pl", "Anna", "Nowak", "234567890", "Dowódca" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1988, 3, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "piotr.zielinski@osp.pl", "Piotr", "Zieliński", "345678901" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1995, 11, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "k.wisniewska@osp.pl", "Katarzyna", "Wiśniewska", "456789012", "Ratownik" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1987, 7, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "marek.wojcik@osp.pl", "Marek", "Wójcik", "567890123" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1993, 6, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "magda.kaczmarek@osp.pl", "Magdalena", "Kaczmarek", "678901234", "Ratownik" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1989, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "t.mazur@osp.pl", "Tomasz", "Mazur", "789012345" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1994, 9, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), "ewa.krawczyk@osp.pl", "Ewa", "Krawczyk", "890123456", "Dowódca" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1986, 2, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "pawel.piotrowski@osp.pl", "Paweł", "Piotrowski", "901234567" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1991, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "a.dabrowska@osp.pl", "Agnieszka", "Dąbrowska", "012345678", "Ratownik" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff1@osp.pl", "Imię1", "Nazwisko1", "123456781" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1990, 1, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff2@osp.pl", "Imię2", "Nazwisko2", "123456782", "Strażak" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 1, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff3@osp.pl", "Imię3", "Nazwisko3", "123456783" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1990, 1, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff4@osp.pl", "Imię4", "Nazwisko4", "123456784", "Strażak" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 1, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff5@osp.pl", "Imię5", "Nazwisko5", "123456785" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1990, 1, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff6@osp.pl", "Imię6", "Nazwisko6", "123456786", "Strażak" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff7@osp.pl", "Imię7", "Nazwisko7", "123456787" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1990, 1, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff8@osp.pl", "Imię8", "Nazwisko8", "123456788", "Strażak" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(1990, 1, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff9@osp.pl", "Imię9", "Nazwisko9", "123456789" });

            migrationBuilder.UpdateData(
                table: "Firefighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "Email", "FirstName", "LastName", "Phone", "Rank" },
                values: new object[] { new DateTime(1990, 1, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), "ff10@osp.pl", "Imię10", "Nazwisko10", "1234567810", "Strażak" });
        }
    }
}
