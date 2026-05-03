using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementApplicationDAL.Migrations
{
    /// <inheritdoc />
    public partial class AuthDbcreationinProddbv10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28b43410-0ccc-42d8-9388-13e50fb304a9", "54b604ca-3373-4e7e-979f-a4ac0f530459" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92c45b3a-aa65-42d2-8676-948b220b720c", "f23fbc7b-5ab1-4364-9752-feae53928ec4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b311b544-0176-4dbc-8dca-d6acc8fb78d4", "54b604ca-3373-4e7e-979f-a4ac0f530459" },
                    { "66274e81-f4fa-4b15-b60f-1c8ad8318c7b", "f23fbc7b-5ab1-4364-9752-feae53928ec4" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091608d1-4929-4dc7-b570-8e4eb1504b97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "991244b8-0e0a-4a6e-b72f-4f2ec92b6768", "AQAAAAIAAYagAAAAENRC1GmDNL0GgPs2K1seGZVpKqhVrbZm7D93mqdvWhM09iuoQULz1zc4CbBe3XE46A==", "64f09265-5d87-4faa-ac76-6aabb0a513e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54b604ca-3373-4e7e-979f-a4ac0f530459",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7785965-83c4-4edd-8786-ed83fa962843", "AQAAAAIAAYagAAAAEAPyTSAjlGbhzWi6GuHRyKvuoWrV0EcVt4HZAlk6L9n5DAWEPxK0Brr+5hD6PkqJfw==", "7430e3da-03f3-4d5e-9b95-7dc08637ca6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "891373ed-0d7d-4e63-80a3-9e560ce553d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "165542d8-76a0-4e5c-81a4-f0a8ff7b9bb0", "AQAAAAIAAYagAAAAEFd3apG0MBZ538lCykIKJPP1mx93xywU0Pu+/+NUplfMc9dreW3gdqzyD3H6oIlSUQ==", "97c3fa1b-ebbc-4ac0-ac1f-f83c7c43dca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f23fbc7b-5ab1-4364-9752-feae53928ec4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850ce79a-2bfe-4d59-a15a-9c66033dd7b5", "AQAAAAIAAYagAAAAEFBjclD0hIKlWTTn6OVC7HlCpMIWqHnlP3jYHLad5pKLZlOVHMxmNP/rMAM8YyrHyg==", "92888ee8-7907-4ff0-b2e7-db75be936289" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b311b544-0176-4dbc-8dca-d6acc8fb78d4", "54b604ca-3373-4e7e-979f-a4ac0f530459" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66274e81-f4fa-4b15-b60f-1c8ad8318c7b", "f23fbc7b-5ab1-4364-9752-feae53928ec4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28b43410-0ccc-42d8-9388-13e50fb304a9", "54b604ca-3373-4e7e-979f-a4ac0f530459" },
                    { "92c45b3a-aa65-42d2-8676-948b220b720c", "f23fbc7b-5ab1-4364-9752-feae53928ec4" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091608d1-4929-4dc7-b570-8e4eb1504b97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acfc2d8c-a562-44d8-8178-309be220cbeb", "AQAAAAIAAYagAAAAEJnfU4lf8ar6ObdI5y8TXezo/R2fnAE1iXA3QQnw6QyvkHOt5kWL6aHAlLMI/DRXCg==", "d0845750-e473-4461-9bc9-491f815310c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54b604ca-3373-4e7e-979f-a4ac0f530459",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88f84d3d-2e1a-443d-86fa-09822ce7829f", "AQAAAAIAAYagAAAAED4uW/mG4Eu96hLpOC4G124Rjuc1x1vSPPBHRpTlQDqhge3IX/LvKbzRUUkWvXSSwg==", "ce99cf48-50c3-4ccb-9e1d-eeaa9a27d7db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "891373ed-0d7d-4e63-80a3-9e560ce553d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd378be-da27-413d-a3fb-688c58a968e8", "AQAAAAIAAYagAAAAEG90VYBc1i2Js4z79lKBEfMIAI/whfeqBY7UQdgYE/6cRhQ+MgENzkUcmFtoC2QlRw==", "e09eed45-7456-4172-bd1d-2b6560b647ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f23fbc7b-5ab1-4364-9752-feae53928ec4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7143fc23-eb36-4996-baf9-903393c12831", "AQAAAAIAAYagAAAAEMdg+uIWWq/4NPo/m2T3dar0ogQC6ZXdWmh4zl+L1wknn9KbsKx61L7Jlnn5HxcI+Q==", "d53d0c90-0872-4a24-82f7-9a42c53bb713" });
        }
    }
}
