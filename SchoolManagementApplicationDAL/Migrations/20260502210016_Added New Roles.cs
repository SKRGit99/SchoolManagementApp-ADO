using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementApplicationDAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adb1abf0-c8dd-45a6-b760-bc61c30c4fef", "adb1abf0-c8dd-45a6-b760-bc61c30c4fef", "Principal", "Principal" },
                    { "ddb9168c-704f-44af-8403-8def10a67eb1", "ddb9168c-704f-44af-8403-8def10a67eb1", "Director", "Director" },
                    { "fe342b15-5975-41d8-83cb-d7b1b8b8b152", "fe342b15-5975-41d8-83cb-d7b1b8b8b152", "Guest", "Guest" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a1f05ea-ca6d-45e7-b558-82150290af0b",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b520fa96-b94d-4feb-b6d6-cc9141ca0b3c", "superadmin@skr91.com", "SUPERADMIN@SKR91.COM", "SUPERADMIN@SKR91.COM", "AQAAAAIAAYagAAAAEKM4f3LE9XR+eLGFpZcOdk8LZZCG61HOkAca2hB7SMj1THWWkzhOEAYxP1++o4ykFg==", "29f91817-2b06-4a3c-bc97-183661672257", "superadmin@skr91.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25973b30-2677-46d7-9b72-584ede7a5c6e", 0, "5abef6da-efb0-4647-b0f1-d0f33d2724c0", "principal@skr91.com", false, false, null, "PRINCIPAL@SKR91.COM", "PRINCIPAL@SKR91.COM", "AQAAAAIAAYagAAAAEFU5o20UOCHNh6upFctNRYAxAe2GnzRGGAmpRHXTOMnErQbW98i4g/8BDaZbZxxzaA==", null, false, "a151e065-da0d-441c-b49a-1559af20af75", false, "principal@skr91.com" },
                    { "7c604289-9d4d-4051-90b2-5e7b8982d6ae", 0, "e417e571-c254-4f4d-810c-d5bdc8e11243", "educator@skr91.com", false, false, null, "EDUCATOR@SKR91.COM", "EDUCATOR@SKR91.COM", "AQAAAAIAAYagAAAAEOg1S2iCQhSt0CYEqPRIxC6y7B3uTAf2H9itJSTrLIfo2lrjjWAKdNVfMLdn2b2Opw==", null, false, "28d761c0-532b-49c7-9f7f-ad6643c9e10a", false, "educator@skr91.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "31371bcb-ae05-4d27-967b-b27047aecbf7", "25973b30-2677-46d7-9b72-584ede7a5c6e" },
                    { "568a834c-3049-492e-ae5d-09b7dc39db19", "25973b30-2677-46d7-9b72-584ede7a5c6e" },
                    { "ac9ff895-6c6a-4653-a52d-f42947a30810", "25973b30-2677-46d7-9b72-584ede7a5c6e" },
                    { "f473d18b-b0ff-4606-9e80-8dda261019c9", "25973b30-2677-46d7-9b72-584ede7a5c6e" },
                    { "adb1abf0-c8dd-45a6-b760-bc61c30c4fef", "4a1f05ea-ca6d-45e7-b558-82150290af0b" },
                    { "31371bcb-ae05-4d27-967b-b27047aecbf7", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" },
                    { "568a834c-3049-492e-ae5d-09b7dc39db19", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" },
                    { "f473d18b-b0ff-4606-9e80-8dda261019c9", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb9168c-704f-44af-8403-8def10a67eb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe342b15-5975-41d8-83cb-d7b1b8b8b152");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31371bcb-ae05-4d27-967b-b27047aecbf7", "25973b30-2677-46d7-9b72-584ede7a5c6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "568a834c-3049-492e-ae5d-09b7dc39db19", "25973b30-2677-46d7-9b72-584ede7a5c6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac9ff895-6c6a-4653-a52d-f42947a30810", "25973b30-2677-46d7-9b72-584ede7a5c6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f473d18b-b0ff-4606-9e80-8dda261019c9", "25973b30-2677-46d7-9b72-584ede7a5c6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adb1abf0-c8dd-45a6-b760-bc61c30c4fef", "4a1f05ea-ca6d-45e7-b558-82150290af0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31371bcb-ae05-4d27-967b-b27047aecbf7", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "568a834c-3049-492e-ae5d-09b7dc39db19", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f473d18b-b0ff-4606-9e80-8dda261019c9", "7c604289-9d4d-4051-90b2-5e7b8982d6ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adb1abf0-c8dd-45a6-b760-bc61c30c4fef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25973b30-2677-46d7-9b72-584ede7a5c6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c604289-9d4d-4051-90b2-5e7b8982d6ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a1f05ea-ca6d-45e7-b558-82150290af0b",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3493eb6b-6b12-49a2-8e33-68cbdb43936e", "director@skr91.com", "DIRECTOR@SKR91.COM", "DIRECTOR@SKR91.COM", "AQAAAAIAAYagAAAAED4dfkkiGyKEoMyx+BxzDvEhRi4EQPh6BYOUlWPms8G1vFPJcKBX/rWH+dcgfSXGuQ==", "178934b1-53bd-49ae-9b29-6db3550922e2", "director@skr91.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63da928e-9896-4f73-8c1b-0ea5a9500b80",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2cc943-1187-43e5-b2d8-342f506b0fd3", "AQAAAAIAAYagAAAAEPRm3YEudyMLh4HQqaueudZr5D+xxK9lE1sbbemp5pGL75VGJKIazhLbXRHZGxmpVA==", "b07dc701-6dfe-4258-90f8-844b6a89cc79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cffae1f-2c3a-4588-b176-7e6691a5c1b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "461c137f-0b79-418a-8541-c5f451db28d3", "AQAAAAIAAYagAAAAEMpgHvUspJ0myTicxZP8iivAGkiMTBmiUptQWDu38iI/oRiYcoRqKdvSYtzJ8fNxJw==", "18915fe2-b0a2-4620-aabe-25cb09366f63" });
        }
    }
}
