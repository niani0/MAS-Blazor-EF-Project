using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class ChangingGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "00a62e0a-b5da-4a14-8d12-8815986725fb");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "3c54bbcf-2738-4beb-a1ed-32ef1ff96c61");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "607138f0-d25c-41d9-abc1-a3df9d66e15a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "676f66a0-362c-47a2-9f6e-4812283ef9e8");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "74f4b10c-61a8-488e-af31-c98c4d785df7");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "7d790367-185b-4d32-ad8c-955a50c51f35");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "a50071b1-4645-4e34-9ae2-10ec89b27bd1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "d3bc6c5f-b21f-479a-af92-ee2d9f834343");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e2fbc513-f341-4b39-9c6b-fc266cadfe03");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e78ab901-33eb-4746-8a93-09abd164d2bd");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "20b8164c-7937-4079-9bdb-a077ac361da3");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "53ca0472-0290-48ea-a831-66baf97c62f8");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "92d52d17-3da4-45e3-bc8c-00c5f67d683d");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "ceacbcfc-1122-4099-a451-374d38d9d8cf");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "db3be581-b0c8-4e63-b1e1-f870d08ccbad");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "05f953cb-11fe-4779-a97f-ebcb815272a9");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "2c1fa606-5cbd-4404-ad1b-150c0b6133f5");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "3246c944-7793-40e9-b365-146b97910944");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "7492b2c0-33d1-479c-8a72-afbda8c033e1");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "75a8805b-90df-46c6-a1d4-6286604f298e");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "a42d62c6-24ed-4465-91d6-deb09862d464");

            migrationBuilder.DeleteData(
                table: "WorkersGroup",
                keyColumn: "Id",
                keyValue: "cf5a7aad-9e98-4c85-94d0-2f3ef6aa3541");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Birthdate", "FirstName", "LastName", "PersonType", "Pesel", "Salary", "Seniority" },
                values: new object[,]
                {
                    { "00a62e0a-b5da-4a14-8d12-8815986725fb", new DateTime(1993, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(291), "John", "Smith", "SawmillWorker", "34567890123", 1100f, 8 },
                    { "3c54bbcf-2738-4beb-a1ed-32ef1ff96c61", new DateTime(1992, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(332), "Ivan", "Petrov", "SawmillWorker", "01234567890", 1020f, 5 },
                    { "607138f0-d25c-41d9-abc1-a3df9d66e15a", new DateTime(1995, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(295), "Maria", "Garcia", "SawmillWorker", "45678901234", 1300f, 3 },
                    { "676f66a0-362c-47a2-9f6e-4812283ef9e8", new DateTime(1999, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(315), "Hans", "Müller", "SawmillWorker", "67890123456", 1150f, 9 },
                    { "74f4b10c-61a8-488e-af31-c98c4d785df7", new DateTime(1997, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(327), "Élise", "Dubois", "SawmillWorker", "90123456789", 1400f, 2 },
                    { "7d790367-185b-4d32-ad8c-955a50c51f35", new DateTime(2003, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(246), "Jan", "Kowalski", "SawmillWorker", "12345678901", 1000f, 10 },
                    { "a50071b1-4645-4e34-9ae2-10ec89b27bd1", new DateTime(1996, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(318), "Carlos", "Ramos", "SawmillWorker", "78901234567", 1250f, 4 },
                    { "d3bc6c5f-b21f-479a-af92-ee2d9f834343", new DateTime(1998, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(287), "Anna", "Nowak", "SawmillWorker", "23456789012", 1200f, 5 },
                    { "e2fbc513-f341-4b39-9c6b-fc266cadfe03", new DateTime(1994, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(323), "Akiko", "Yamamoto", "SawmillWorker", "89012345678", 1350f, 7 },
                    { "e78ab901-33eb-4746-8a93-09abd164d2bd", new DateTime(1991, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(299), "Li", "Chen", "SawmillWorker", "56789012345", 1050f, 6 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CreatedAt", "FinishDate", "State" },
                values: new object[,]
                {
                    { "20b8164c-7937-4079-9bdb-a077ac361da3", new DateTime(2023, 6, 19, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 6, 20, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(380), "New" },
                    { "53ca0472-0290-48ea-a831-66baf97c62f8", new DateTime(2023, 6, 27, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 6, 28, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(436), "New" },
                    { "92d52d17-3da4-45e3-bc8c-00c5f67d683d", new DateTime(2023, 6, 21, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(388), new DateTime(2023, 6, 22, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(389), "New" },
                    { "ceacbcfc-1122-4099-a451-374d38d9d8cf", new DateTime(2023, 6, 23, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 6, 24, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(396), "New" },
                    { "db3be581-b0c8-4e63-b1e1-f870d08ccbad", new DateTime(2023, 6, 25, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 6, 26, 10, 24, 29, 928, DateTimeKind.Local).AddTicks(430), "New" }
                });

            migrationBuilder.InsertData(
                table: "WorkersGroup",
                columns: new[] { "Id", "Specialization" },
                values: new object[,]
                {
                    { "05f953cb-11fe-4779-a97f-ebcb815272a9", "Planing" },
                    { "2c1fa606-5cbd-4404-ad1b-150c0b6133f5", "Packing" },
                    { "3246c944-7793-40e9-b365-146b97910944", "Drying" },
                    { "7492b2c0-33d1-479c-8a72-afbda8c033e1", "Wood" },
                    { "75a8805b-90df-46c6-a1d4-6286604f298e", "Sawing" },
                    { "a42d62c6-24ed-4465-91d6-deb09862d464", "Loading" },
                    { "cf5a7aad-9e98-4c85-94d0-2f3ef6aa3541", "Metal" }
                });
        }
    }
}
