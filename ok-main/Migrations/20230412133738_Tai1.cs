using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class Tai1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12310edd-7d8c-4fba-b424-1ea066e17129", "AQAAAAEAACcQAAAAENNgg+bT+tQ9LAOP8c5mhYgwlqtMEv5kY5baMWwhjtZ7UYQUn5dyVaZdByvMGtRkSA==", "15dde4b8-2049-43ae-a428-e7a617752013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d00b857-6e6e-4852-a150-1ea534942fb4", "AQAAAAEAACcQAAAAEP14qxlS0sj0/JAZ6rGElgqLmdr1D9bk3x+gupocIFa6SRb+urQ+cPaUuHVOSfHZmA==", "f938af85-d3db-48c0-a1ae-04ce44ba7706" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd61b6d-0514-4f66-b43e-4a0a39d7840f", "AQAAAAEAACcQAAAAEJ6b02pWr+w9TR3zddFL1BrFYy3C/i4vdYhkoNIpMgaNXFsVZWgKeE3QyQm+pMmDpQ==", "6dc06d0a-a350-45df-b633-3b6950cca115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63ae3001-1bae-454a-b993-be906feec4f0", "AQAAAAEAACcQAAAAEOoIV7MSwN98449dtR9KoOer+yBJzy6sAt1pVfRlpKozW4Sym5HuQgTpE2yD+YwfsQ==", "02ff01cd-043f-4b6b-96a9-66deb4abb842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "763597bb-30e5-4f54-9d81-1ebe1f47537b", "AQAAAAEAACcQAAAAEA3iQ8HiL5qDClNbuNmeHE7QQC1dl/+agMIkpN+QTcVCtXWCmM6wGigONqmAb4jzwA==", "02a1c149-655b-4f83-8dd3-dbe532a03a4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "854ba91c-b7c4-4477-870b-f20759aa4804", "AQAAAAEAACcQAAAAEEl1GuhZL3fpi24ah5AkinikUynvJM2JRcepVANU6Fws/Az0T+E+MSyGVjTWW0LLMw==", "5e573d48-d4c7-4e88-a19b-34c0f34d7e03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "3bac7616-d859-429e-9424-3ca5f6142ebc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "d9218d25-303a-4dc8-a295-55a97b1f3145");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "O",
                column: "ConcurrencyStamp",
                value: "ac99c03a-51e5-4bcd-b555-c0d664442407");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83361aa-226f-4190-8795-22d4fb572d1e", "AQAAAAEAACcQAAAAEI75IKdpQWVDPW1EC124BhPqQM5NS8WlCRMKJNEk2/S0/qT1HppZgFev91jSy33zYQ==", "fa3c346a-e444-488a-8b75-1b590ac78556" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "151163c3-4f92-4415-805a-05391f677768", "AQAAAAEAACcQAAAAEPvLuDmCfrdW7oWckQHMJMwk9s8k+9oK4tpVZhQtWsLnhCCj8K/blNN1MvEQI4UZZA==", "87cbc5b0-4d72-4dc4-9c6d-60914d3f5612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4facc453-372c-4ca6-bb24-8be2da0a6515", "AQAAAAEAACcQAAAAEBsA74fkWwq5m6FbPvR7GSVQsfDOkTQKXBk878VcVESB04bTsilTIOmK18I2A+Ja7A==", "05c1c139-c2e1-4970-b98e-62731d22cb8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93788144-9528-463e-8f02-b77d9de19de8", "AQAAAAEAACcQAAAAEEMg9QJ0GklPTkKjCzHLHEHkVTFJIqifZJ33qwLY8qNU+BZyB0s68A0MmWY2Y12ifA==", "e3e6823f-636d-418b-9e75-cb7a7baaff9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17ce5e8-05d4-4a83-a844-5a2d261743a2", "AQAAAAEAACcQAAAAENybcAlasJtczMLHh+Wctfups04u44+i0MGF/0OyBmxVbg1DLjhdWLYS82ixIlCp3Q==", "3e6aec71-4039-4e0d-982d-33ef4e89ffcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d21fcb7-e8df-4df3-a04f-c2a312f6846b", "AQAAAAEAACcQAAAAELhS7UGAocjgvdc0JjwrSZtG0/oz18EIaZrsh2Wh4Ue2TJZiSS5MHXivkPPZDhzPsw==", "aa0bff58-9007-47a5-b004-de0fed6ebf30" });
        }
    }
}
