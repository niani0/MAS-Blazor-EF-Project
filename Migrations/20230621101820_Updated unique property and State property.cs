using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class UpdateduniquepropertyandStateproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "1656dd31-ac1a-4e60-9462-f8b9d65160f3");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "22b00bde-8860-469e-bf48-e67094167b0e");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "438c8271-5b44-4dfb-8d96-46d15046fd63");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "549d8da1-90c9-4aa0-a92b-09ffc826bd5a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "6f0ddca0-95d6-4c1e-95cd-daea9a56dec1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "81e25eac-4056-4cad-a995-21ec512935db");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "97f57ba3-1ac9-4ce4-b7de-d17fec7d9ade");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "cf4bf642-d80b-4a5c-8f26-b29dc6e7b6ac");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e4e5cac1-f8bc-47cd-a7b9-11f6e419fba2");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f5ce5bef-9259-495b-9034-bc6465295096");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "1b6c6760-49ec-4502-aa17-b7f2aee0901c");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "51e9036e-0edb-4b08-a347-4f826af5dd9f");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "9cad8423-2050-4de1-b4f4-f7498204038e");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "cfa91a29-0d01-4e3c-a8bb-ffe6fd56ea7a");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "f2abc50d-836b-4742-9a96-8ec8e3b2d185");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "228c567a-a8f1-4c44-ab9b-52ecd668b6ea");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "3318df56-ef1e-44c2-b1f9-c855ab0e85e0");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "4967a668-f8e3-448d-b741-3ff3b8f9d7ee");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "7d535b13-443c-43e1-a710-e4566237952a");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "99cf32cd-f585-4fb3-ac38-2926db63a503");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "f1111b2f-8215-496b-8cf5-ec5f1ad275a0");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "ff977d59-3b28-49a7-ab9d-b202f5391930");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Material",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName", "PersonType", "Pesel", "Salary", "Seniority" },
                values: new object[,]
                {
                    { "1e2f7823-63ec-491c-9607-8f38a7dea02a", new DateTime(1996, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(992), "Carlos", "Ramos", "SawmillWorker", "78901234567", 1250f, 4 },
                    { "32232c76-5a3c-4791-891c-ed1e47b52084", new DateTime(1991, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(963), "Li", "Chen", "SawmillWorker", "56789012345", 1050f, 6 },
                    { "61d331fa-dfc4-4f4c-818c-e9e423fa028e", new DateTime(2003, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(886), "Jan", "Kowalski", "SawmillWorker", "12345678901", 1000f, 10 },
                    { "ac3eaf10-be6b-490e-aa75-e61cdc4f2df5", new DateTime(1998, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(945), "Anna", "Nowak", "SawmillWorker", "23456789012", 1200f, 5 },
                    { "c3bf523f-222f-4923-a810-9a173a488fcd", new DateTime(1999, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(987), "Hans", "Müller", "SawmillWorker", "67890123456", 1150f, 9 },
                    { "ca690b00-c9bd-41db-b45a-2cd99aa21cd1", new DateTime(1992, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1010), "Ivan", "Petrov", "SawmillWorker", "01234567890", 1020f, 5 },
                    { "ddddab79-2cc5-4476-84ab-e47e9499a611", new DateTime(1994, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(998), "Akiko", "Yamamoto", "SawmillWorker", "89012345678", 1350f, 7 },
                    { "e1edbaa3-ee91-477c-984b-b31fd9e96054", new DateTime(1995, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(958), "Maria", "Garcia", "SawmillWorker", "45678901234", 1300f, 3 },
                    { "ed9f905c-31b5-4ff6-b6a7-664c3abf7316", new DateTime(1993, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(952), "John", "Smith", "SawmillWorker", "34567890123", 1100f, 8 },
                    { "ffe6242e-e69b-4112-a23a-30fa3e6a608b", new DateTime(1997, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1003), "Élise", "Dubois", "SawmillWorker", "90123456789", 1400f, 2 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CreatedAt", "FinishDate", "State" },
                values: new object[,]
                {
                    { "35503c15-c2d9-45ca-aacf-3003b230ca9f", new DateTime(2023, 6, 25, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 6, 26, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1092), "New" },
                    { "5690f7b2-2d72-4820-967e-c862097704b6", new DateTime(2023, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 6, 22, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1072), "New" },
                    { "752c251a-21c4-45a3-a939-e21549f5b21b", new DateTime(2023, 6, 29, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 6, 30, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1109), "New" },
                    { "b32d3219-9a98-4b87-bb3c-536c37a0ac44", new DateTime(2023, 6, 27, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 6, 28, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1102), "New" },
                    { "f5489292-fa7a-4eb2-aec9-943cd9928257", new DateTime(2023, 6, 23, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1082), new DateTime(2023, 6, 24, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1084), "New" }
                });

            migrationBuilder.InsertData(
                table: "WorkersGroup",
                columns: new[] { "Id", "Specialization" },
                values: new object[,]
                {
                    { "0978f6a0-c149-4e75-9f84-decd19c284f1", "Wood" },
                    { "1ca188cf-01cd-4f8a-9850-22b9830f458b", "Loading" },
                    { "1e91a95c-f5c0-4527-b3ac-5978e58ef40d", "Wood" },
                    { "52036687-412c-4bd5-9cde-2a244cc475dc", "Metal" },
                    { "59239a0d-e0c3-423a-8d27-13dadf9348ec", "Planing" },
                    { "82c7b484-0cb9-4d95-ae02-d1e9a32b1c5b", "Packing" },
                    { "e60d36d8-cce3-4190-a55a-4681d3e4d21e", "Wood" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Material_Name",
                table: "Material",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Material_Name",
                table: "Material");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "1e2f7823-63ec-491c-9607-8f38a7dea02a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "32232c76-5a3c-4791-891c-ed1e47b52084");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "61d331fa-dfc4-4f4c-818c-e9e423fa028e");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ac3eaf10-be6b-490e-aa75-e61cdc4f2df5");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "c3bf523f-222f-4923-a810-9a173a488fcd");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ca690b00-c9bd-41db-b45a-2cd99aa21cd1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ddddab79-2cc5-4476-84ab-e47e9499a611");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e1edbaa3-ee91-477c-984b-b31fd9e96054");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ed9f905c-31b5-4ff6-b6a7-664c3abf7316");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ffe6242e-e69b-4112-a23a-30fa3e6a608b");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "35503c15-c2d9-45ca-aacf-3003b230ca9f");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "5690f7b2-2d72-4820-967e-c862097704b6");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "752c251a-21c4-45a3-a939-e21549f5b21b");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "b32d3219-9a98-4b87-bb3c-536c37a0ac44");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "f5489292-fa7a-4eb2-aec9-943cd9928257");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "0978f6a0-c149-4e75-9f84-decd19c284f1");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "1ca188cf-01cd-4f8a-9850-22b9830f458b");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "1e91a95c-f5c0-4527-b3ac-5978e58ef40d");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "52036687-412c-4bd5-9cde-2a244cc475dc");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "59239a0d-e0c3-423a-8d27-13dadf9348ec");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "82c7b484-0cb9-4d95-ae02-d1e9a32b1c5b");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "e60d36d8-cce3-4190-a55a-4681d3e4d21e");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Material",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName", "PersonType", "Pesel", "Salary", "Seniority" },
                values: new object[,]
                {
                    { "1656dd31-ac1a-4e60-9462-f8b9d65160f3", new DateTime(1992, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4233), "Ivan", "Petrov", "SawmillWorker", "01234567890", 1020f, 5 },
                    { "22b00bde-8860-469e-bf48-e67094167b0e", new DateTime(1998, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4201), "Anna", "Nowak", "SawmillWorker", "23456789012", 1200f, 5 },
                    { "438c8271-5b44-4dfb-8d96-46d15046fd63", new DateTime(1997, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4229), "Élise", "Dubois", "SawmillWorker", "90123456789", 1400f, 2 },
                    { "549d8da1-90c9-4aa0-a92b-09ffc826bd5a", new DateTime(1995, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4209), "Maria", "Garcia", "SawmillWorker", "45678901234", 1300f, 3 },
                    { "6f0ddca0-95d6-4c1e-95cd-daea9a56dec1", new DateTime(1993, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4205), "John", "Smith", "SawmillWorker", "34567890123", 1100f, 8 },
                    { "81e25eac-4056-4cad-a995-21ec512935db", new DateTime(1991, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4212), "Li", "Chen", "SawmillWorker", "56789012345", 1050f, 6 },
                    { "97f57ba3-1ac9-4ce4-b7de-d17fec7d9ade", new DateTime(1999, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4216), "Hans", "Müller", "SawmillWorker", "67890123456", 1150f, 9 },
                    { "cf4bf642-d80b-4a5c-8f26-b29dc6e7b6ac", new DateTime(2003, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4161), "Jan", "Kowalski", "SawmillWorker", "12345678901", 1000f, 10 },
                    { "e4e5cac1-f8bc-47cd-a7b9-11f6e419fba2", new DateTime(1996, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4220), "Carlos", "Ramos", "SawmillWorker", "78901234567", 1250f, 4 },
                    { "f5ce5bef-9259-495b-9034-bc6465295096", new DateTime(1994, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4224), "Akiko", "Yamamoto", "SawmillWorker", "89012345678", 1350f, 7 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CreatedAt", "FinishDate", "State" },
                values: new object[,]
                {
                    { "1b6c6760-49ec-4502-aa17-b7f2aee0901c", new DateTime(2023, 6, 19, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 6, 20, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4283), "New" },
                    { "51e9036e-0edb-4b08-a347-4f826af5dd9f", new DateTime(2023, 6, 27, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 6, 28, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4306), "New" },
                    { "9cad8423-2050-4de1-b4f4-f7498204038e", new DateTime(2023, 6, 23, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 6, 24, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4296), "New" },
                    { "cfa91a29-0d01-4e3c-a8bb-ffe6fd56ea7a", new DateTime(2023, 6, 21, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 6, 22, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4291), "New" },
                    { "f2abc50d-836b-4742-9a96-8ec8e3b2d185", new DateTime(2023, 6, 25, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 6, 26, 14, 3, 21, 801, DateTimeKind.Local).AddTicks(4301), "New" }
                });

            migrationBuilder.InsertData(
                table: "WorkersGroup",
                columns: new[] { "Id", "Specialization" },
                values: new object[,]
                {
                    { "228c567a-a8f1-4c44-ab9b-52ecd668b6ea", "Planing" },
                    { "3318df56-ef1e-44c2-b1f9-c855ab0e85e0", "Metal" },
                    { "4967a668-f8e3-448d-b741-3ff3b8f9d7ee", "Wood" },
                    { "7d535b13-443c-43e1-a710-e4566237952a", "Wood" },
                    { "99cf32cd-f585-4fb3-ac38-2926db63a503", "Wood" },
                    { "f1111b2f-8215-496b-8cf5-ec5f1ad275a0", "Loading" },
                    { "ff977d59-3b28-49a7-ab9d-b202f5391930", "Packing" }
                });
        }
    }
}
