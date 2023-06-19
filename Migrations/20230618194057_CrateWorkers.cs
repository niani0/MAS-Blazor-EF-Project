using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class CrateWorkers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName", "PersonType", "Pesel", "Salary", "Seniority" },
                values: new object[,]
                {
                    { "2c99f051-51db-47b9-ae8f-af2bc3206f63", new DateTime(1995, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5329), "Maria", "Garcia", "SawmillWorker", "45678901234", 1300f, 3 },
                    { "462b72ea-c501-418d-8bbe-054ec0d3afa4", new DateTime(1992, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5421), "Ivan", "Petrov", "SawmillWorker", "01234567890", 1020f, 5 },
                    { "6f982598-27f4-458d-b77d-805ea5e9e93b", new DateTime(1999, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5343), "Hans", "Müller", "SawmillWorker", "67890123456", 1150f, 9 },
                    { "8db2b14a-3cd7-4dab-bdaa-093b93ac566a", new DateTime(1994, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5369), "Akiko", "Yamamoto", "SawmillWorker", "89012345678", 1350f, 7 },
                    { "908bb7f3-58a1-4146-b0f8-9f916ce2fcc5", new DateTime(1997, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5375), "Élise", "Dubois", "SawmillWorker", "90123456789", 1400f, 2 },
                    { "9e5e8048-2b0a-48d0-8d6f-e6d58f9b14df", new DateTime(2003, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5254), "Jan", "Kowalski", "SawmillWorker", "12345678901", 1000f, 10 },
                    { "bd6b19e5-a7cf-44eb-a4cd-c08c70378da7", new DateTime(1996, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5361), "Carlos", "Ramos", "SawmillWorker", "78901234567", 1250f, 4 },
                    { "e6a839a2-78f7-4a30-b0e7-693a7c69271b", new DateTime(1993, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5322), "John", "Smith", "SawmillWorker", "34567890123", 1100f, 8 },
                    { "e9319454-622e-4bd0-b012-01e57a13b7f1", new DateTime(1991, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5335), "Li", "Chen", "SawmillWorker", "56789012345", 1050f, 6 },
                    { "f79ec260-eed1-4937-8100-d8a9099f5d3f", new DateTime(1998, 6, 18, 21, 40, 57, 119, DateTimeKind.Local).AddTicks(5315), "Anna", "Nowak", "SawmillWorker", "23456789012", 1200f, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "2c99f051-51db-47b9-ae8f-af2bc3206f63");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "462b72ea-c501-418d-8bbe-054ec0d3afa4");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "6f982598-27f4-458d-b77d-805ea5e9e93b");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "8db2b14a-3cd7-4dab-bdaa-093b93ac566a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "908bb7f3-58a1-4146-b0f8-9f916ce2fcc5");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "9e5e8048-2b0a-48d0-8d6f-e6d58f9b14df");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "bd6b19e5-a7cf-44eb-a4cd-c08c70378da7");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e6a839a2-78f7-4a30-b0e7-693a7c69271b");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e9319454-622e-4bd0-b012-01e57a13b7f1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f79ec260-eed1-4937-8100-d8a9099f5d3f");
        }
    }
}
