using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class Tai2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DoB",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b1bb1ba6-4036-4436-be8a-a288f16ce19b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "6f9bca51-778a-4c62-8a28-cd67a330c739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "7f620e89-b3af-436f-b0bd-26caceaf6167");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "377af383-5074-49c4-9a57-b1481f2784eb", "AQAAAAEAACcQAAAAEB1lT6FJpGg5ybge+zXZM+MmwGazM0Wb4dXR9Gvqep6iOyTXUZcTMmwqMltMeETJrA==", "02771251-0d61-4b4e-949d-1b5ab8c71e3b", new DateTime(2002, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "d44a9224-2e99-4a2c-95be-a0b7b2f885dc", "AQAAAAEAACcQAAAAED0ZUCMc1PDj+++SXupJ5jNKNFLzd+Oe/zCoDJZuvx/29dypO6abmyjzn2Ik5wXEbw==", "6dcd7596-e58d-4d68-b86d-abb488a30d21", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "4a37791c-af9a-4561-89fd-f6f8c3c90793", "AQAAAAEAACcQAAAAEFbfoQKxzGXpfzpVWOxqMNM1IOsJzXDwJAq2aJUHM08B86rqP6cntPAW622FqchBeg==", "d80a4f9b-126e-44fc-99f9-24f6ec8a5cd7", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "40ae5159-29af-4189-84db-e8352a5ac1ab", "AQAAAAEAACcQAAAAEHMDy+G548K3WjbBYK9+MWMgKw5Q0qPWiFdsq+4TnWpXByVZ58kvL9FUMhoZbUIb2g==", "4976cec3-67ee-4751-a72e-bbcebc4bb1b8", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "621ec72e-36cd-49bc-aae9-da5525a5d0ba", "AQAAAAEAACcQAAAAEBn8EZq7uyFK4YOBlCoQrJBiXk+z+NdJ4V4fZJK5sAl8NlgthKBdBr8E3jFdvAHhig==", "91ff21d6-a247-44ce-a9d4-9c6535a66409", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "d8d07f20-0096-4cd7-a4d9-f99e581cb97a", "AQAAAAEAACcQAAAAEMoI8B0p1ZD/xhi460maNLcfI7bfkHwPUjjnZyf79uJX1TpKv30r5SX4yPcC234yMQ==", "de71e52c-cd35-482a-ae44-b280fdfe3cf3", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DoB",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "6169a1cf-cbf4-4fc8-8f6d-a2c63cdff69d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "2c9ee79d-6793-4295-9495-9116b0633484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "974f777e-c41b-4252-b9df-7bee69fe82ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "12310edd-7d8c-4fba-b424-1ea066e17129", "AQAAAAEAACcQAAAAENNgg+bT+tQ9LAOP8c5mhYgwlqtMEv5kY5baMWwhjtZ7UYQUn5dyVaZdByvMGtRkSA==", "15dde4b8-2049-43ae-a428-e7a617752013", "2002/04/04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "9d00b857-6e6e-4852-a150-1ea534942fb4", "AQAAAAEAACcQAAAAEP14qxlS0sj0/JAZ6rGElgqLmdr1D9bk3x+gupocIFa6SRb+urQ+cPaUuHVOSfHZmA==", "f938af85-d3db-48c0-a1ae-04ce44ba7706", "2002/01/01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "acd61b6d-0514-4f66-b43e-4a0a39d7840f", "AQAAAAEAACcQAAAAEJ6b02pWr+w9TR3zddFL1BrFYy3C/i4vdYhkoNIpMgaNXFsVZWgKeE3QyQm+pMmDpQ==", "6dc06d0a-a350-45df-b633-3b6950cca115", "2002/01/01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "63ae3001-1bae-454a-b993-be906feec4f0", "AQAAAAEAACcQAAAAEOoIV7MSwN98449dtR9KoOer+yBJzy6sAt1pVfRlpKozW4Sym5HuQgTpE2yD+YwfsQ==", "02ff01cd-043f-4b6b-96a9-66deb4abb842", "2002/01/01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "763597bb-30e5-4f54-9d81-1ebe1f47537b", "AQAAAAEAACcQAAAAEA3iQ8HiL5qDClNbuNmeHE7QQC1dl/+agMIkpN+QTcVCtXWCmM6wGigONqmAb4jzwA==", "02a1c149-655b-4f83-8dd3-dbe532a03a4c", "2002/01/01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "DoB" },
                values: new object[] { "854ba91c-b7c4-4477-870b-f20759aa4804", "AQAAAAEAACcQAAAAEEl1GuhZL3fpi24ah5AkinikUynvJM2JRcepVANU6Fws/Az0T+E+MSyGVjTWW0LLMw==", "5e573d48-d4c7-4e88-a19b-34c0f34d7e03", "2002/01/01" });
        }
    }
}
