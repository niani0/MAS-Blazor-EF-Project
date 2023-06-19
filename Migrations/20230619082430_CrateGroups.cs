using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class CrateGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "049d04df-06b9-4901-95f3-961239fdc2e3");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "058c09e2-14c8-44b5-a014-56206deed0af");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "18c1fdf6-7d2b-4799-a361-62633b1fbf59");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "36caef2e-e26a-4771-a69b-d6f167e61113");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "507fa4c1-5ecc-40de-af4c-c0c5dad36c26");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "5c29d98c-da51-44d2-a080-106367df70e1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "75e6d8df-27df-4647-8423-0c52039e0eba");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "7d4e4fb2-8fb2-4023-a440-fdde21183ee7");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "82c1ba5c-8c46-4076-9fd3-2207a977e840");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e7336361-7c3d-40d1-8fb0-7afd49cf9c77");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "453dd610-ea58-4b24-8e2d-5fdcce065bc1");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "49bb638f-8e95-4338-8b11-cd51e52fd1b6");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "6550ee68-bd91-40a2-a849-c7b18927a02d");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "6819d699-52db-4137-afe5-497990dcb19e");

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: "924bf26b-12af-4d6d-8c34-3c78715bcc25");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "049d04df-06b9-4901-95f3-961239fdc2e3", new DateTime(1995, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4517), "Maria", "Garcia", "SawmillWorker", "45678901234", 1300f, 3 },
                    { "058c09e2-14c8-44b5-a014-56206deed0af", new DateTime(1993, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4512), "John", "Smith", "SawmillWorker", "34567890123", 1100f, 8 },
                    { "18c1fdf6-7d2b-4799-a361-62633b1fbf59", new DateTime(1994, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4548), "Akiko", "Yamamoto", "SawmillWorker", "89012345678", 1350f, 7 },
                    { "36caef2e-e26a-4771-a69b-d6f167e61113", new DateTime(1998, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4507), "Anna", "Nowak", "SawmillWorker", "23456789012", 1200f, 5 },
                    { "507fa4c1-5ecc-40de-af4c-c0c5dad36c26", new DateTime(1992, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4558), "Ivan", "Petrov", "SawmillWorker", "01234567890", 1020f, 5 },
                    { "5c29d98c-da51-44d2-a080-106367df70e1", new DateTime(1999, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4528), "Hans", "Müller", "SawmillWorker", "67890123456", 1150f, 9 },
                    { "75e6d8df-27df-4647-8423-0c52039e0eba", new DateTime(1991, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4521), "Li", "Chen", "SawmillWorker", "56789012345", 1050f, 6 },
                    { "7d4e4fb2-8fb2-4023-a440-fdde21183ee7", new DateTime(1997, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4552), "Élise", "Dubois", "SawmillWorker", "90123456789", 1400f, 2 },
                    { "82c1ba5c-8c46-4076-9fd3-2207a977e840", new DateTime(1996, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4533), "Carlos", "Ramos", "SawmillWorker", "78901234567", 1250f, 4 },
                    { "e7336361-7c3d-40d1-8fb0-7afd49cf9c77", new DateTime(2003, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4460), "Jan", "Kowalski", "SawmillWorker", "12345678901", 1000f, 10 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CreatedAt", "FinishDate", "State" },
                values: new object[,]
                {
                    { "453dd610-ea58-4b24-8e2d-5fdcce065bc1", new DateTime(2023, 6, 23, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 6, 24, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4662), "New" },
                    { "49bb638f-8e95-4338-8b11-cd51e52fd1b6", new DateTime(2023, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 6, 20, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4644), "New" },
                    { "6550ee68-bd91-40a2-a849-c7b18927a02d", new DateTime(2023, 6, 27, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 6, 28, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4674), "New" },
                    { "6819d699-52db-4137-afe5-497990dcb19e", new DateTime(2023, 6, 21, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4653), new DateTime(2023, 6, 22, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4655), "New" },
                    { "924bf26b-12af-4d6d-8c34-3c78715bcc25", new DateTime(2023, 6, 25, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 6, 26, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4668), "New" }
                });
        }
    }
}
