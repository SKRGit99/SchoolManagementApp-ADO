using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementApplicationDAL.Migrations
{
    /// <inheritdoc />
    public partial class AuthenticationTablescreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66274e81-f4fa-4b15-b60f-1c8ad8318c7b", "091608d1-4929-4dc7-b570-8e4eb1504b97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92c45b3a-aa65-42d2-8676-948b220b720c", "091608d1-4929-4dc7-b570-8e4eb1504b97" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "091608d1-4929-4dc7-b570-8e4eb1504b97" },
                    { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "54b604ca-3373-4e7e-979f-a4ac0f530459" },
                    { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "891373ed-0d7d-4e63-80a3-9e560ce553d9" },
                    { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "f23fbc7b-5ab1-4364-9752-feae53928ec4" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "091608d1-4929-4dc7-b570-8e4eb1504b97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "54b604ca-3373-4e7e-979f-a4ac0f530459" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "891373ed-0d7d-4e63-80a3-9e560ce553d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55ed1dd3-fab2-45d9-8315-f44c9b1a56b6", "f23fbc7b-5ab1-4364-9752-feae53928ec4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "66274e81-f4fa-4b15-b60f-1c8ad8318c7b", "091608d1-4929-4dc7-b570-8e4eb1504b97" },
                    { "92c45b3a-aa65-42d2-8676-948b220b720c", "091608d1-4929-4dc7-b570-8e4eb1504b97" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091608d1-4929-4dc7-b570-8e4eb1504b97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b5ae709-6dac-4642-b741-c1f15c41ec03", "AQAAAAIAAYagAAAAEL0b+MvNx+Jltw1Dx2gcXpUiPU47dyMmJQ4VUz7HGkHUJGen3SjcAxq2Hm+PjDWYRQ==", "44f900b3-8c18-4e0b-ba2a-ee54046c1392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54b604ca-3373-4e7e-979f-a4ac0f530459",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1518d319-4e7b-4df5-8d3c-cb5f2ee643f6", "AQAAAAIAAYagAAAAEEptjqTKwkLZEMfXMwoa/VK5L+h+Kyf6Sf6ipPNhi0YSWzOUy9UfuH/qsMwpCCvp2g==", "7c121721-d6b0-4ed4-aada-258fea375940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "891373ed-0d7d-4e63-80a3-9e560ce553d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c9180a9-9151-45f0-b284-7c61375eefd8", "AQAAAAIAAYagAAAAENhX2AJupQr93xKIapidHHrGAnyaHZD6xGd3KBRV5pF9CtNvMyoz7saxG0NsQsVPFA==", "64a13ea6-8083-4ef5-8dd8-0c4c7a6793ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f23fbc7b-5ab1-4364-9752-feae53928ec4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afb3d2ee-c972-4f2f-a303-505d8a456daf", "AQAAAAIAAYagAAAAEJn8EZ+Ed8FCa2Ztxqv56/EPf2d/rfLbyjkEfJfwYMu26qm/vmqd/9YGC0x85jW9Aw==", "5a46c536-8928-436b-adf4-52714a09fd03" });
        }
    }
}
