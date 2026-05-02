using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplicationDAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewIdentityRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25973b30-2677-46d7-9b72-584ede7a5c6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b5e557b-ccd7-42c2-8bda-f3bbd608d638", "AQAAAAIAAYagAAAAEBBICsihamscRTT7JF2eTIE8R9mfraPX12TiH37/f66m3Z8boezBkDvadDp/Q+aOdg==", "0c7c24f9-ea10-48d6-b22b-d34c50b57068" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a1f05ea-ca6d-45e7-b558-82150290af0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c7f3765-bb15-48e8-ab9d-46219bff8765", "AQAAAAIAAYagAAAAEKY+dfruecCIaISo7LyfFPFbD8PKm5krmUlEcZl3PXKeTRrx8SRrFWHDSHMcC2nKMw==", "8b94016f-6b12-401d-8db7-857a62e78c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63da928e-9896-4f73-8c1b-0ea5a9500b80",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7948de41-e08b-41ff-a95d-98da13a4b11d", "students@skr91.com", "STUDENTS@SKR91.COM", "STUDENTS@SKR91.COM", "AQAAAAIAAYagAAAAEHFyLINysV70MyJpZn27uVPVdM3BmaBtXFrmSfQJQn4Ieh2lZRo7YVdr5VFFBAIEKQ==", "2f5d08f8-a9f1-40a3-80ec-e801b9762b65", "students@skr91.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cffae1f-2c3a-4588-b176-7e6691a5c1b2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a138492d-33bf-484c-ab41-20773a4cff60", "faculty@skr91.com", "FACULTY@SKR91.COM", "FACULTY@SKR91.COM", "AQAAAAIAAYagAAAAEJDvBv8NJc4cDHE/tB/JTIpe+epkqcrqQcEDOMgy8Yd1MZ4FBs1DKJ2Bsr+ekeIB/g==", "83e39569-30e5-4a79-98d7-952104361ed0", "faculty@skr91.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c604289-9d4d-4051-90b2-5e7b8982d6ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae82068a-5f33-43a8-b150-7d49156806a3", "AQAAAAIAAYagAAAAEP0fR88gW1aef6bu/UOZy9k0syAIZi+nygJiva4pJhPGkYD+He9gCGMYgLdpaNuVjg==", "db61b194-5930-4136-b5fd-f5af3de7dfdb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25973b30-2677-46d7-9b72-584ede7a5c6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf6d442-844d-4423-b2dc-3548b57fda17", "AQAAAAIAAYagAAAAEO11TwdOhvi2eacIiAEughNYSoi9BGy81Pc5Q7IeTSuMilqVVgqnm/r29rKNUZ8FRQ==", "b0974086-5caf-4d6a-bb75-36e285c78dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a1f05ea-ca6d-45e7-b558-82150290af0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c6b3b3b-47b3-4013-8e9e-9ad191f2174c", "AQAAAAIAAYagAAAAECJEQvinok0FQub1/ToEhP6waAk6de+UsBsR2VhR3EQfGNLJS+RyJ107T7fgVs1rJg==", "dcf2eba8-181f-40ea-a9ad-c768f8f974b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63da928e-9896-4f73-8c1b-0ea5a9500b80",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ca2f348c-be34-4649-b8bb-0e8dbf7bdeea", "student@skr91.com", "STUDENT@SKR91.COM", "STUDENT@SKR91.COM", "AQAAAAIAAYagAAAAEDIhK/h+b9wOSVwrFpCAnr5uGSokMB13dqbgslk7JMG149trY09O5jVkPj3x9QhYQA==", "a5248305-4021-49bc-a0f0-c3b9da4b3e47", "student@skr91.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cffae1f-2c3a-4588-b176-7e6691a5c1b2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "08b74805-e683-4000-86b6-58ba824de888", "educator@skr91.com", "EDUCATOR@SKR91.COM", "EDUCATOR@SKR91.COM", "AQAAAAIAAYagAAAAEAOSe0Ih7rV8DBChoXDvgDxZkJJiNoMKJitRGHPWsq1plDv2TygdAvW6MXtXJcfBhg==", "2527bc41-7960-4ef9-9d97-9bca5f204903", "educator@skr91.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c604289-9d4d-4051-90b2-5e7b8982d6ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd34750-b9ed-4e05-a7a2-92008d4b88ea", "AQAAAAIAAYagAAAAEEj3I5eTSqhqSYq8hptudrSQpkoYoEcEbTgN6ergprNuXc1cUL8U8vjLrbnqBZ5+xA==", "3568e607-69b5-460a-9eb9-331c142f7737" });
        }
    }
}
