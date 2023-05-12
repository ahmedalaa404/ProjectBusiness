using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Work.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "029bff78-5216-4df5-8f08-d6d83a1b92f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356a612e-5511-43ef-a38b-0934b5a7764e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82985b4d-ed89-4e32-8471-3e4e050eb0e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7cb22bf-6a26-48d9-9c3f-99540ad4c337");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "012f2fa5-cd79-4fb5-b786-4b2acbdfd6cb", "b76fc036-ee62-4727-ab71-fa8a83d32f81", "Investor", "INVESTOR" },
                    { "1e75d706-be24-4128-a353-efb9fefbadfd", "7b9d8787-f3ff-4f05-abc3-9674e75ff3e9", "Graduate", "GRADUATE" },
                    { "d51761b4-8903-43a8-8d26-adf7802b2766", "a82a9e9b-5b7b-4f4d-877d-6c7bc37af3f6", "Specialist", "SPECIALIST" },
                    { "e4c4a3a7-390a-4663-bcb6-638f8e0d8ef2", "3fdf582d-13dc-4c3a-a1f1-eb40d144b567", "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "012f2fa5-cd79-4fb5-b786-4b2acbdfd6cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e75d706-be24-4128-a353-efb9fefbadfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51761b4-8903-43a8-8d26-adf7802b2766");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c4a3a7-390a-4663-bcb6-638f8e0d8ef2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "029bff78-5216-4df5-8f08-d6d83a1b92f1", "ff17709c-035f-46e1-942f-9ffcad3abd8e", "Graduate", "GRADUATE" },
                    { "356a612e-5511-43ef-a38b-0934b5a7764e", "34db68fa-ad73-42e0-8789-e04952fd6656", "Investor", "INVESTOR" },
                    { "82985b4d-ed89-4e32-8471-3e4e050eb0e6", "b1293227-9dda-4d81-9ca7-9ea0c0687453", "Student", "STUDENT" },
                    { "d7cb22bf-6a26-48d9-9c3f-99540ad4c337", "62f55c81-fffc-4818-a75e-c5524af728b3", "Specialist", "SPECIALIST" }
                });
        }
    }
}
