using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplicationDAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2f348c-be34-4649-b8bb-0e8dbf7bdeea", "AQAAAAIAAYagAAAAEDIhK/h+b9wOSVwrFpCAnr5uGSokMB13dqbgslk7JMG149trY09O5jVkPj3x9QhYQA==", "a5248305-4021-49bc-a0f0-c3b9da4b3e47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cffae1f-2c3a-4588-b176-7e6691a5c1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08b74805-e683-4000-86b6-58ba824de888", "AQAAAAIAAYagAAAAEAOSe0Ih7rV8DBChoXDvgDxZkJJiNoMKJitRGHPWsq1plDv2TygdAvW6MXtXJcfBhg==", "2527bc41-7960-4ef9-9d97-9bca5f204903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c604289-9d4d-4051-90b2-5e7b8982d6ae",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6fd34750-b9ed-4e05-a7a2-92008d4b88ea", "employee@skr91.com", "EMPLOYEE@SKR91.COM", "EMPLOYEE@SKR91.COM", "AQAAAAIAAYagAAAAEEj3I5eTSqhqSYq8hptudrSQpkoYoEcEbTgN6ergprNuXc1cUL8U8vjLrbnqBZ5+xA==", "3568e607-69b5-460a-9eb9-331c142f7737", "employee@skr91.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25973b30-2677-46d7-9b72-584ede7a5c6e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5abef6da-efb0-4647-b0f1-d0f33d2724c0", "AQAAAAIAAYagAAAAEFU5o20UOCHNh6upFctNRYAxAe2GnzRGGAmpRHXTOMnErQbW98i4g/8BDaZbZxxzaA==", "a151e065-da0d-441c-b49a-1559af20af75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a1f05ea-ca6d-45e7-b558-82150290af0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b520fa96-b94d-4feb-b6d6-cc9141ca0b3c", "AQAAAAIAAYagAAAAEKM4f3LE9XR+eLGFpZcOdk8LZZCG61HOkAca2hB7SMj1THWWkzhOEAYxP1++o4ykFg==", "29f91817-2b06-4a3c-bc97-183661672257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63da928e-9896-4f73-8c1b-0ea5a9500b80",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc8cad9-8cb9-4655-89e6-8f830aa197ab", "AQAAAAIAAYagAAAAEOAoAvYi2K7j8KL3zORZ8LZHiOci2VnBjg6W0GLFj/3TDGgxzq/mQJBhXyp78KChsA==", "af378a48-afa3-4df6-afd8-37dd23164784" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cffae1f-2c3a-4588-b176-7e6691a5c1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716fbf90-db32-4ea3-935e-cd292a061e9a", "AQAAAAIAAYagAAAAEHLTSO8ovBVTyUM1vrkwpk3R9+wRJ+FUPPyO+H594pXjP2hB7hsOCKHEv7cYcUK/TA==", "54020ee4-e436-4cbb-8329-a8f4c8f5734c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c604289-9d4d-4051-90b2-5e7b8982d6ae",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e417e571-c254-4f4d-810c-d5bdc8e11243", "educator@skr91.com", "EDUCATOR@SKR91.COM", "EDUCATOR@SKR91.COM", "AQAAAAIAAYagAAAAEOg1S2iCQhSt0CYEqPRIxC6y7B3uTAf2H9itJSTrLIfo2lrjjWAKdNVfMLdn2b2Opw==", "28d761c0-532b-49c7-9f7f-ad6643c9e10a", "educator@skr91.com" });
        }
    }
}
