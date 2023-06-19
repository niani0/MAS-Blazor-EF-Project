using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_19c.Migrations
{
    /// <inheritdoc />
    public partial class CrateTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
